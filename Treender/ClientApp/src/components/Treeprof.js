import React from "react";

import mock3 from "../img/Trees/tree11.jpg";

function Treeprof(props) {
  let source, type, specie, height, name;

  props.tree.Height != undefined
    ? (height = props.tree.Height)
    : (height = 101);

  typeof props.tree.Image == "string" && props.tree.Image.length >= 150
    ? (source = `data:image/jpeg;base64,${props.tree.Image}`)
    : (source = mock3);

  props.tree.Type == 1 ? (type = "Real") : (type = "Fake");

  props.tree.Specie == 1
    ? (specie = "Spurce")
    : props.tree.Specie == 2
    ? (specie = "Fir")
    : (specie = "Pine");
  return (
    <div>
      <div className="offset-1 col-10 offset-md-4 col-md-4 offset-xl-4 col-xl-3 treeprof">
        <div>
          <img
            src={source}
            className="img-fluid position-relative treeprofphoto"
          />
          <div className="treedata">
            <p>{props.tree.Name}</p>
            <p>{height + " cm"}</p>
            <p>{type}</p>
            <p>{specie}</p>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Treeprof;
