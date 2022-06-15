import React, { useState } from "react";
import { Link, useNavigate } from "react-router-dom";

export default function CreatePost(props) {
  const [title, setTitle] = useState("");
  const [description, setDescription] = useState("");
  const [success, setSuccess] = useState(false);
  let navigatePage = useNavigate();

  const SubmitHandler = async (e) => {
    e.preventDefault();

    if (title === "" || description === "") {
      console.log("errors");
    } else {
      await fetch("http://localhost:5118/api/Post/createpost", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          title,
          description,
        }),
      });

      setSuccess(true);
    }
  };

  if (success) {
    navigatePage("/");
  }

  return (
    <main className="form-signin w-100 m-auto">
      <div className="col-12 d-flex justify-content-end mt-3">
        <Link className="btn btn-primary" to="/" name={props.name}>
          Back
        </Link>
      </div>

      <form onSubmit={SubmitHandler}>
        <div className="form-floating">
          <input
            type="text"
            className={"form-control"}
            id="floatingInput"
            placeholder="Title"
            value={title}
            onChange={(e) => setTitle(e.target.value)}
          />
          <label htmlFor="floatingInput">Title</label>
        </div>

        <div className="form-floating">
          <input
            type="text"
            className="form-control"
            id="floatingInput"
            placeholder="Description"
            value={description}
            onChange={(e) => setDescription(e.target.value)}
          />
          <label htmlFor="floatingInput">Description</label>
        </div>

        <button className="w-100 btn btn-lg btn-primary" type="submit">
          Create Post
        </button>
        <p className="mt-5 mb-3 text-muted">&copy; 2022</p>
      </form>
    </main>
  );
}
