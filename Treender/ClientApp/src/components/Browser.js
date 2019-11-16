import React, { Component } from "react";
import Treeprof from "./Treeprof";
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

  componentDidMount() {
    fetch("/GetUserTrees").then(e => console.log(e));
  }

  iconShow = e => {
    let father = document.getElementById("browser");
    let el = document.createElement("img");
    el.src = e;
    el.classList.add("iconShow");

    el.style.animation = "show 1s ease-in-out";

    father.appendChild(el);

    el.addEventListener("animationend", function() {
      father.removeChild(el);
    });
  };

  render() {
    return (
      <div className="col-12 d-flex flex-column">
        <div id="browser">
          <Treeprof tree={this.state} />
        </div>
        <div className="d-flex justify-content-center">
          <div>
            <div
              className="swipeIcon"
              onClick={() => {
                this.iconShow(ximage);
              }}
            >
              <img src={ximage} />
            </div>
          </div>
          <div>
            <div
              className="swipeIcon"
              onClick={() => {
                this.iconShow(hearthimage);
              }}
            >
              <img src={hearthimage} />
            </div>
          </div>
        </div>
      </div>
    );
  }
}
