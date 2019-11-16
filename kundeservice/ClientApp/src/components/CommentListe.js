import React from "react";
import CommentBox from "./CommentBox";

export default function CommentListe(props) {
  return (
    <div className="commentListe">
      <h5 className="text-muted mb-4">
        <span className="badge badge-success">{props.comments.length}</span>{" "}
           Svar og spørsmål{props.comments.length > 0 ? "s" : ""}
      </h5>
      {props.comments.map((comment, index) => (
        <CommentBox key={index} comment={comment} />
      ))}
    </div>
  );
}