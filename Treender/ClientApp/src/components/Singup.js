import React, { Component } from "react";
import "./Signup.css";
import { Link } from "react-router-dom";
import { connect } from "react-redux";
import whitetree from "../img/Icon white.png";

class Singup extends Component {
  constructor() {
    super();

    this.state = {
      username: "Mieczkowski_69"
    };
  }

  newUsername = e => {
    console.log(this.props);
    this.setState({
      username: e.target.value
    });
  };

  sendUsername = () => {
    fetch("/Login", {
      method: "POST",
      headers: {
        Accept: "text/html",
        "Content-Type": "text/html"
      },
      body: this.state.username
    });

    this.props.changeName(this.state.username);
  };

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
            <input
              type="text"
              name="nickname"
              onChange={this.newUsername}
              class="offset-3 col-6"
            />
          </label>
          <Link to="/browse" username={this.state.username}>
            <button
              type="button"
              className="btn btn-tinder"
              onClick={this.sendUsername}
            >
              {" "}
              Create an account!
            </button>
          </Link>
        </form>
      </div>
    );
  }
}

const mapStateToProps = props => {
  return {
    reducero: props.reducero
  };
};

const mapDispatchToProps = dispatch => {
  return {
    changeName: username => {
      dispatch({ type: "CHANGE_NAME", username: username });
    }
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(Singup);
