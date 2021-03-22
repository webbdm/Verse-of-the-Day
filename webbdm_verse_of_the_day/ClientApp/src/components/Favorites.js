import React, { useState, useEffect } from 'react';

export const Favorites = () => {
    const [favorites, setFavorites] = useState([]);

    useEffect(() => {
        const getFavorites = async () => {
            setFavorites(await (await fetch("favorites/api/all", {
                method: 'GET'
            })).json());
        }

        getFavorites();

    }, [favorites]);

    if(!favorites) return null;

    return (
        <React.Fragment>
        <h2 className="favorites-header">My Favorites</h2>
            <div className="favorites-wrapper">
                <div className="favorites-box">
              
                    {favorites.map((favorite) =>
                        <div className="favorites-panel" key={favorite.id}>
                            <div className="favorites-left">
                                <div>
                                    <div className="favorites-text">
                                        <span className="favorites-verse-text left-corner-text">{favorite.verse.referenceText}</span>
                                   
                        </div>

                                    <span className="favorites-verse-text">{favorite.verse.verseText}</span>
                                    </div>
                    </div>
                            <div className="favorites-right">
                                    <img src={favorite.verse.imageLink} />
                            </div>
                        </div>

                    )}
                </div>
            </div>
         </React.Fragment>
        )
}
