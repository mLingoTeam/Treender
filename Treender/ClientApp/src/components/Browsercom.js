import React, { Component } from "react";
import Treeprof from "./Treeprof";
import ximage from "../img/X.png";
import hearthimage from "../img/heart.png";
import "./Browserstyle.css";
import mock from "../img/christams tree photo.jpg";
import { connect } from "react-redux";

class Browsercom extends Component {
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
    this.fetchApiToEntries("/GetUserTrees");
  }
  fetchApiToEntries = apiToFetch => {
      fetch(apiToFetch,
          {
              method: "GET",
              headers: {
                  "Accept": "application/json",
                  "Content-Type": "application/json",
                  "name": this.props.username
              }
          })
      .then(result => result.json())
      .then(entries => console.log(entries))
      .catch(error => console.log(error));
  };

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
              <img src={ximage} className="img-fluid" />
            </div>
          </div>
          <div>
            <div
              className="swipeIcon"
              onClick={() => {
                this.iconShow(hearthimage);
              }}
            >
              <img src={hearthimage} className="img-fluid" />
            </div>
          </div>
        </div>
      </div>
    );
  }
}

const mapStateToProps = state => {
  return {
    username: state.username
  };
};

export default connect(mapStateToProps)(Browsercom);
