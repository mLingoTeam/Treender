import React, { Component } from "react";
import Treeprof from "./Treeprof";
import ximage from "../img/X.png";
import hearthimage from "../img/heart.png";
import "./Browserstyle.css";
import mock from "../img/christams tree photo.jpg";
import mock2 from "../img/Icon.png";
import mock3 from "../img/Trees/tree11.jpg";
import { connect } from "react-redux";
import sadface from "../img/sad_face.png";

class Browsercom extends Component {
  constructor() {
    super();

    this.increment = 0;
    const initialState = [
      {
        Name: "Mieczkowski",
        Height: 1.8,
        Specie: "Sosna",
        Type: "Real",
        Description: "lorem ipsum barttek immilllokwoski",
        Image: mock3
      },
      {
        name: "Mieczkowski2",
        height: 1.8,
        specie: "Sosna",
        type: "Real",
        description: "lorem ipsum barttek immilllokwoski",
        image: mock2
      },
      {
        name: "Mieczkowski3",
        height: 1.8,
        specie: "Sosna",
        type: "Real",
        description: "lorem ipsum barttek immilllokwoski",
        image: mock
      },
      {
        name: "Mieczkowski4",
        height: 1.8,
        specie: "Sosna",
        type: "Real",
        description: "lorem ipsum barttek immilllokwoski",
        image: mock2
      },
      {
        name: "Mieczkowski5",
        height: 1.8,
        specie: "Sosna",
        type: "Real",
        description: "lorem ipsum barttek immilllokwoski",
        image: mock
      },
      {
        name: "Mieczkowski6",
        height: 1.8,
        specie: "Sosna",
        type: "Real",
        description: "lorem ipsum barttek immilllokwoski",
        image: mock2
      },
      {
        name: "Mieczkowski7",
        height: 1.8,
        specie: "Sosna",
        type: "Real",
        description: "lorem ipsum barttek immilllokwoski",
        image: mock
      }
    ];
    this.state = { increment: 0, obj: initialState };
  }

  componentDidMount() {
    this.fetchApiToEntries("/GetUserTrees");
  }
  fetchApiToEntries = apiToFetch => {
    fetch(apiToFetch, {
      method: "GET",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json",
        name: this.props.username
      }
    })
      .then(result => result.json())
      .then(entries => JSON.parse(entries))
      .then(entries =>
        this.setState({
          ...this.state,
          obj: entries,
          increment: this.state.increment
        })
      )
      .then(entries => console.log(this.state))
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

    setTimeout(() => {
      this.setState({ ...this.state, increment: (this.increment += 1) });
    }, 1000);
  };

  render() {
    /*if (this.state.increment >= this.state.obj.length) {
      return (
        <div className="offset-2 col-8 endoftrees">
          <h2>End of trees! Buy a VIP profile to search more...</h2>
          <img src={sadface} className="img-fluid position-relative" />
        </div>
      );
    } else {
         */
    return (
      <div className="col-12 d-flex flex-column">
        <div id="browser">
          <Treeprof tree={{ ...this.state.obj[this.state.increment] }} />
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
//}

const mapStateToProps = state => {
  return {
    username: state.username
  };
};

export default connect(mapStateToProps)(Browsercom);
