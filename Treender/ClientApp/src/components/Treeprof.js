import React from "react";

function Treeprof(props) {
  let source;
  props.tree.Image.length >= 150
    ? (source = `data:image/jpeg;base64,${props.tree.Image}`)
    : (source = props.tree.Image);
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
            <p>{props.tree.Height}</p>
            <p>{props.tree.Type}</p>
            <p>{props.tree.Specie}</p>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Treeprof;
