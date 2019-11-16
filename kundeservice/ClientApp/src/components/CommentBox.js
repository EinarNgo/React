import React from "react";
//import { CollapsibleComponent, CollapsibleHead, CollapsibleContent } from 'react-collapsible-component';
import Card from 'react-bootstrap/Card';
import Accordion from 'react-bootstrap/Accordion';
import { Button } from 'reactstrap';

export default function CommentBox(props) {
    const { id, ask, ans, kat, pRat, nRat } = props.comment;

    
    return (
        <Accordion defaultActiveKey="1">
            <Card>
                <Accordion.Toggle as={Card.Header} eventKey="0">
                    {ask}
                </Accordion.Toggle>
                <Accordion.Collapse eventKey="0">
                    <Card.Body>{ans}
                        <p> </p>
                        <Button color="success">Like - {pRat}</Button>
                        {" "}
                        <Button color="danger">Dislike - {nRat}</Button>

                    </Card.Body>
                    
                </Accordion.Collapse>
            </Card>
        </Accordion>
       
        
        /*
        <div>
            <CollapsibleComponent>
                <CollapsibleHead className="additionalClassForHead">Head title 1</CollapsibleHead>
                <CollapsibleContent className="additionalClassForContent">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit,
                    sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                    Ut enim ad minim veniam, quis nostrud exercitation ullamco
                    laboris nisi ut aliquip ex </p>
                </CollapsibleContent>

                <CollapsibleHead isExpanded={true}>Head title 2</CollapsibleHead>
                <CollapsibleContent isExpanded={true}>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit,
                    sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                    Ut enim ad minim veniam, quis nostrud exercitation ullamco
                    laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure
                    dolor in reprehenderit in voluptate velit esse cillum dolore eu
                    fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident,
                    sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
                </CollapsibleContent>

                <CollapsibleHead>Head title 3</CollapsibleHead>
                <CollapsibleContent>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit,
                    sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                    Ut enim ad minim veniam, quis nostrud exercitation ullamco
                    laboris nisi ut aliquip ex ea commodo consequat. </p>
                </CollapsibleContent>
            </CollapsibleComponent>
        </div>
        */
    );
    
}