import React, { Component } from 'react';

import { Link } from 'react-router-dom';

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
    return (
        <div className="navigation">
            <div className="nav-left">
                <img className="logo" src="../../Assets/klove_logo.png" />
            </div>
            <h1 className="nav-title">Verse of the Day</h1>
            <div className="nav-right">
                <a href="/">Get Verses</a>
                <a href="/favorites">My Favorites</a>
            </div>
        </div>
    );
  }
}
