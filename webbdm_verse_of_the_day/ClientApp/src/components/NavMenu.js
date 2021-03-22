import React, { Component } from 'react';

import { Link } from 'react-router-dom';

export const NavMenu = () =>
    <div className="navigation">
        <div className="nav-left">
            <img className="logo" src="../../Assets/klove_logo.png" />
        </div>
        <h1 className="nav-title">Verse of the Day</h1>
        <div className="nav-right">
            <a href="/ClientApp">Get Verses</a>
            <a href="ClientApp/favorites">My Favorites</a>
        </div>
    </div>;
