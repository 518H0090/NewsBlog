import React, { useState } from "react";
import { useEffect } from "react";
import { useParams, Link } from "react-router-dom";

export default function ViewPost(props) {
  const { postid } = useParams();

  const [title, setTitle] = useState("");
  const [description, setDescription] = useState("");

  useEffect(() => {
    (async () => {
      const response = await fetch("http://localhost:5118/api/Post/" + postid);
      const data = await response.json();

      setTitle(data.title);
      setDescription(data.description);
    })();
  }, []);

  return (
    <div>
      <div
        className="d-flex justify-content-end mt-3"
        style={{ marginRight: "120px" }}
      >
        <Link className="btn btn-primary" to="/" name={props.name}>
          Back
        </Link>
      </div>

      <div>{title}</div>
      <div>{description}</div>
    </div>
  );
}
