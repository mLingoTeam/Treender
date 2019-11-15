import React, { Component } from "react";
import Signup from "./Singup";
import "./NavMenu.css";

class Logo extends Component {
  render() {
    return (
      <div>
        <span class="navbar navbar-default">
          <span class="container-fluid">
            <span class="navbar-header">
              <a class="navbar-brand" href="#">
                Treender
              </a>
            </span>
          </span>
        </span>
        <Signup />
      </div>
    );
  }
}

export default Logo;
