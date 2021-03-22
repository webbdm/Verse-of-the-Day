import React from 'react';

export const NavMenu = () =>
    <div className="navigation">
        <div className="nav-left">
            <img className="logo" src="../../Assets/klove_logo.png" alt="K-Love Logo" />
        </div>
        <h1 className="nav-title">Verse of the Day</h1>
        <div className="nav-right">
            <a href="/ClientApp">Get Verses</a>
            <a href="ClientApp/favorites">My Favorites</a>
        </div>
    </div>;
