import React, { useEffect, useState } from "react";
import { Link } from "react-router-dom";

export default function Home(props) {
  let getCreate = (
    <div className="col-12 d-flex justify-content-end mt-3">
      <Link className="btn btn-primary" to="/createpost" name={props.name}>
        Create
      </Link>
    </div>
  );

  const [listPost, setListPost] = useState(null);

  useEffect(() => {
    (async () => {
      const response = await fetch("http://localhost:5118/api/Post");

      const data = await response.json();

      setListPost(data);
    })();
  }, []);

  return (
    <div className="container">
      <div className="row ">
        {props.name && getCreate}
        <div className="mt-3">
          <table className="table">
            <thead>
              <tr>
                <th scope="col">#</th>
                <th scope="col">Title</th>
                <th scope="col">Handle</th>
              </tr>
            </thead>
            <tbody>
              {listPost &&
                listPost.map((data) => {
                  return (
                    <tr>
                      <th scope="row">{data.id}</th>
                      <td>{data.title}</td>
                      <td>
                        <Link to={`/viewpost/${data.id}`} name={props.name}>
                          View
                        </Link>
                      </td>
                    </tr>
                  );
                })}
            </tbody>
          </table>
        </div>
      </div>
    </div>
  );
}
