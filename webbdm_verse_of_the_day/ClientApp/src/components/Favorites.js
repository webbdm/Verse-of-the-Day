import React, { Component } from 'react';

export const Favorites = () => {
    const favorites = [];

    return (
        <React.Fragment>
        <h2 class="favorites-header">My Favorites</h2>
            <div class="favorites-wrapper">
                <div class="favorites-box">
              
                    {favorites.map((favorite) =>
                        <div class="favorites-panel">
                            <div class="favorites-left">
                                <form asp-controller="Favorites" action="/unfavorite" method="post">
                        <div class="favorites-text">
                                        <span class="favorites-verse-text left-corner-text">{favorite.verse.referenceText}</span>
                                   
                            <button type="submit">Remove</button>
                        </div>

                                    <span class="favorites-verse-text">{favorite.Verse.VerseText}</span>
                                    </form>
                    </div>
                            <div class="favorites-right">
                                    <img src={favorite.verse.imageLink} />
                            </div>
                        </div>

                    )}
                </div>
            </div>
         </React.Fragment>
        )
}
