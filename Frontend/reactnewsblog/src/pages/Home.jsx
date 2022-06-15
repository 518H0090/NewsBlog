import React from "react";

export default function Home() {
  return (
    <div className="mt-3">
      <table class="table">
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
            <td>Mark</td>
            <td colSpan="2">@mdo</td>
          </tr>
        </tbody>
      </table>
    </div>
  );
}
