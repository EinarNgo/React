import React from "react";
import axios from 'axios';

export class CommentReg extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            loading: false,
            error: "",
            valid: "",

            comment: {
                name: "",
                message: ""
            }
        };

        this.handleFieldChange = this.handleFieldChange.bind(this);
        this.onSubmit = this.onSubmit.bind(this);
    }

    handleFieldChange = event => {
        const { value, name } = event.target;

        this.setState({
            ...this.state,
            comment: {
                ...this.state.comment,
                [name]: value
            }
        });
    };

    onSubmit(e) {
        e.preventDefault();

        if (!this.isFormValid()) {
            this.setState({ error: "All fields are required.", valid: "" });
            return;
        }

        const postData = {
            epost: this.state.comment.name,
            ask: this.state.comment.message
        };
        let { comment } = this.state.comment
        axios.post('api/sporsmal/PostSporsmal', postData)
            .then(res => {
                if (res.status >= 200 && res.status < 300) {
                    this.setState({
                        error: "",
                        valid: "",
                        valid: 'Godkjent',
                        loading: false,
                        comment: { ...comment, name: "", message: ""}
                    });
                } else {
                    this.setState({
                        error: 'Feil',
                        open: true,
                    })
                }
            }, error => {
                console.log(error);
                alert("Feil")
            });
    };


    renderError() {
        return this.state.error ? (
            <div className="alert alert-danger">{this.state.error}</div>
        ) : null;
    }

    renderValid() {
        return this.state.valid ? (
            <div className="alert alert-success">{this.state.valid}</div>
        ) : null;
    }

    isFormValid() {
        return this.state.comment.name !== "" && this.state.comment.message !== "";
    }

    render() {
        return (
            <React.Fragment>
                <form method="post" onSubmit={this.onSubmit}>
                    <div className="form-group">
                        <input
                            onChange={this.handleFieldChange}
                            value={this.state.comment.name}
                            className="form-control"
                            placeholder="Epost"
                            name="name"
                            type="text"
                        />
                    </div>

                    <div className="form-group">
                        <textarea
                            onChange={this.handleFieldChange}
                            value={this.state.comment.message}
                            className="form-control"
                            placeholder="Spørsmål"
                            name="message"
                            rows="5"
                        />
                    </div>

                    {this.renderError()}
                    {this.renderValid()}

                    <div className="form-group">
                        <button disabled={this.state.loading} className="btn btn-primary">
                            Comment &#10148;
            </button>
                    </div>
                </form>
            </React.Fragment>
        );
    }
}
