
import React, { Component } from 'react';
import "bootstrap/dist/css/bootstrap.css";
import Card from 'react-bootstrap/Card';
import Accordion from 'react-bootstrap/Accordion';
import "./Home.css";
import axios from 'axios';
import CommentListe from "./CommentListe"
import { CommentReg } from './CommentReg';

export class Home extends React.Component {

    constructor(props) {
        super(props);

        this.state = {
            comments: [],
            loading: false
        };
    }

    
    componentDidMount() {
        //get all the comments
        fetch("api/sporsmal/HentSporsmal")
            .then(res => res.json())
            .then(res => {
                this.setState({
                    comments: res,
                    loading: false
                });
            })
            .catch(error => {
                this.setState({ loading: false });
                alert("Ingen kontakt med API")
            });
    }
    

    render() {
    return (

        <div className="App container bg-light shadow">
            <header className="App-header">
                <p></p>
                <p></p>
                <h1 className="App-title">
                    FAQ
                </h1>
                <p></p>
                <p></p>
            </header>

            <div className="row">
                <div className="col-4  pt-3 border-right">
                    <h6>Send inn spørsmål:</h6>
                    <CommentReg addComment={this.addComment} />
                </div>
                <div className="col-8  pt-0 bg-black">
                    <div className="row">
                        <div className="col-12  pt-3 bg-white">
                            <CommentListe
                                loading={this.state.loading}
                                comments={this.state.comments}
                            />
                        </div>
                    </div>
                </div>
            </div>
        </div>

    );
  }
}
