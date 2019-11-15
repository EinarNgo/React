import React, { Component } from 'react';
import "bootstrap/dist/css/bootstrap.css";
import Card from 'react-bootstrap/Card';
import Accordion from 'react-bootstrap/Accordion';
import "./Home.css";
import axios from 'axios';

export class Home extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            Comment: []
        };
    }

    componentDidMount() {
        this.fetchSporsmal();
    }

    fetchSporsmal = () => {
        axios.get('api/sporsmals/HentSporsmal')
            .then(response => {
                this.setState({
                    Comment: response.data
                });
            }, error => {
                console.log(error);
                alert('Kunne ikke hente spørsmålene')
            });
    };



    render() {
    return (

        <div className="App container bg-light shadow">
            <header className="App-header">
                <h1 className="App-title">
                    FAQ
                </h1>
                <p>
                    Frequence ask question
                </p>
            </header>

            <div className="row">
                <div className="col-4  pt-3 border-right">
                    <h6>Send inn spørsmål:</h6>
                </div>
                <div className="col-8  pt-3 bg-white">

                    <Accordion defaultActiveKey="0">
                        <Card>
                            <Accordion.Toggle as={Card.Header} eventKey="0">
                                Test
                            </Accordion.Toggle>
                            <Accordion.Collapse eventKey="0">
                                <Card.Body>Hello! I'm the body78</Card.Body>
                            </Accordion.Collapse>
                        </Card>
                        <Card>
                            <Accordion.Toggle as={Card.Header} eventKey="1">
                                Click me!
                            </Accordion.Toggle>
                            <Accordion.Collapse eventKey="1">
                                <Card.Body>Hello! I'm another body</Card.Body>
                            </Accordion.Collapse>
                        </Card>
                    </Accordion>
                </div>
            </div>
        </div>

    );
  }
}

