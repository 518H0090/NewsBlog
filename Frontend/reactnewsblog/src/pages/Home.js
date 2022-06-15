import React from "react";

export default function Home(props) {
  return (
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
          <tr>
            <th scope="row">1</th>
            <td>Hi {props.name}</td>
            <td colSpan="2">@mdo</td>
          </tr>
        </tbody>
      </table>
    </div>
  );
}
