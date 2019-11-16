import React, { Component } from "react";
import Treeprof from "./Treeprof";
import TreeButtons from "./TreeButtons";
import ximage from "../img/X.png";
import hearthimage from "../img/heart.png";
import "./Browser.css";
import mock from "../img/christams tree photo.jpg";

export class Browser extends Component {
  constructor() {
    super();

    this.state = {
      name: "Mieczkowski",
      height: 1.8,
      specie: "Sosna",
      type: "Real",
      description: "lorem ipsum barttek immilllokwoski",
      image: mock
    };
  }

  render() {
    return (
      <div className="col-12 d-flex flex-column">
        <Treeprof tree={this.state} />
        <div className="d-flex justify-content-center">
          <TreeButtons image={ximage} />
          <TreeButtons image={hearthimage} />
        </div>
      </div>
    );
  }
}
