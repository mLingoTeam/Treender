import React, { Component } from "react";
import { Route } from "react-router";
import { Layout } from "./components/Layout";
import Browsercom from "./components/Browsercom";
import Logo from "./components/Logo";

import "./custom.css";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <div>
        <Logo />
        <Route history={this.props.history} exact path="/" component={Layout} />
        <Route path="/browse" component={Browsercom} />
      </div>
    );
  }
}
