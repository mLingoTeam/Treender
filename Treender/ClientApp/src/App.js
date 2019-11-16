import React, { Component } from "react";
import { Route } from "react-router";
import { Layout } from "./components/Layout";
import { Browser } from "./components/Browser";
import Logo from "./components/Logo";

import "./custom.css";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <div>
        <Logo />
        <Route history={this.props.history} exact path="/" component={Layout} />
        <Route path="/browse" component={Browser} />
      </div>
    );
  }
}
