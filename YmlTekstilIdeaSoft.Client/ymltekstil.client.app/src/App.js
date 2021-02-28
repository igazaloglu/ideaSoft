import React, { Component } from 'react';
import './App.css';
import { Route } from "react-router-dom"
import Home from "./components/Home"
import Products from "./components/Products"
import Nav from "./components/Nav"
import Login from "./components/Login"
import Auth from "./Auth/Auth";
import Callback from "./components/Callback";

class App extends Component {
  constructor(props) {
    super(props);
    this.auth = new Auth(this.props.history);
  }
  render() {
    return <>
      <Nav />
      <div className="body">
        <Route path="/"
          exact
          render={props => <Home auth={this.auth} {...props} />}
        />
        <Route path="/callback"
               render={props => <Callback auth={this.auth} {...props} />}
        />
        <Route path="/products" component={Products} />
        <Route path="/login"
               render={props => <Login auth={this.auth} {...props} />}
        />      </div>
    </>

  }
  
}

export default App;