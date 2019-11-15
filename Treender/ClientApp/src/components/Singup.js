import React, { Component } from "react";
import "./Signup.css";
import whitetree from "../img/Icon white.png";

class Singup extends Component {
  render() {
    return (
      <div className="gradient col-12">
        <div className="col-12 col-md-6">
          <img
            src={whitetree}
            className="img-fluid offset-1 col-10 offset-md-2 col-md-8"
          />
        </div>
        <form className="username-form col-md-6">
          <label for="nickname" className="col-12">
            <p>Username</p>
            <input type="text" name="nickname" class="offset-3 col-6" />
          </label>
          <button type="button" className="btn btn-tinder">
            Search your tree!
          </button>
        </form>
      </div>
    );
  }
}

export default Singup;
