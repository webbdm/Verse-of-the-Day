import React, { Component } from 'react';

export const VerseResults = ({ verses }) => {
    return <div class="verse-box">
        {verses.map((verse) =>
            (<div class="verse-panel">
                <span class="verse-text">{verse.referenceText}</span>

                <span class="verse-text">{verse.verseText}</span>

                <button class="favoriteBtn" name="favoriteBtn" id={verse.id}>Favorite</button>

                <img src={verse.imageLink} />

        </div>))}
    </div>
};