import React, { Component } from 'react';

export const VerseResults = () => {
    const verses = [];

    return verses.map((verse) =>
       ( <div class="verse-box">
            <div class="verse-panel">
                <span class="verse-text">@verse.ReferenceText</span>

                <span class="verse-text">@verse.VerseText</span>

                <button class="favoriteBtn" name="favoriteBtn" id={verse.id}>Favorite</button>

                <img src={verse.imagelink} />

            </div>
        </div>
    ));
};