import React, { useState } from 'react';

export const VerseResults = ({ verses }) => {
    const [showingSavedToFavorites, setShowingSavedToFavorites] = useState(false);

    const saveToFavorites = async (verse) => {
        const response = await fetch('/favorited', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-type': 'application/json'
            },
            body: JSON.stringify({
                id: verse.id,
                versetext: verse.verseText,
                book: verse.book,
                chapter: verse.chapter,
                imageLink: verse.imageLink,
                referenceText: verse.referenceText
            })
        });
        if (response.status === 200) setShowingSavedToFavorites(true);

        setTimeout(() => setShowingSavedToFavorites(false), 3000);
    };
    return <div className="verse-box">
        {verses.map((verse) =>
            (<div className="verse-panel" key={verse.id}>
                <span className="verse-text">{verse.referenceText}</span>

                <span className="verse-text">{verse.verseText}</span>

                <button onClick={() => saveToFavorites(verse)} className="favoriteBtn" name="favoriteBtn" id={verse.id}>Favorite</button>
                {showingSavedToFavorites && <p>Saved to Favorites!</p>}

                <img src={verse.imageLink} alt="Verse" />
        </div>))}
    </div>
};