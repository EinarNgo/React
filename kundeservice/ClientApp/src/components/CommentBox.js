import React from "react";
import Card from 'react-bootstrap/Card';
import Accordion from 'react-bootstrap/Accordion';


export default function CommentBox(props) {
    const { id, ask, ans, kat, pRat, nRat } = props.comment;

    
    return (
        <Accordion defaultActiveKey="1">
            <Card>
                <Accordion.Toggle as={Card.Header} eventKey="0">
                    {ask}
                </Accordion.Toggle>
                <Accordion.Collapse eventKey="0">
                    <Card.Body>{ans}</Card.Body>
                </Accordion.Collapse>
            </Card>
        </Accordion>
    );
    
}