import React from "react";

function Treeprof(props) {
  return (
    <div>
      <div className="offset-1 col-10 offset-md-4 col-md-4 offset-xl-4 col-xl-3 treeprof">
        <div>
          <img
            src={props.tree.image}
            className="img-fluid position-relative treeprofphoto"
          />
          <div className="treedata">
            <p>{props.tree.name}</p>
            <p>{props.tree.height}</p>
            <p>{props.tree.type}</p>
            <p>{props.tree.specie}</p>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Treeprof;
