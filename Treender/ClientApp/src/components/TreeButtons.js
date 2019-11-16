import React from "react";

function TreeButtons(props) {
  return (
    <div>
      <div
        className="swipeIcon"
        onClick={function() {
          console.log("click");
        }}
      >
        <img src={props.image} />
      </div>
    </div>
  );
}

export default TreeButtons;
