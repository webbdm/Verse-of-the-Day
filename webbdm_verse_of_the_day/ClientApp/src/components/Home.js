import React, { useState } from 'react';
import { VerseResults } from "./VerseResults";
import { useInput } from "../hooks/useInput";

export const Home = () => {
    const [verses, setVerses] = useState([]);
    const [error, setError] = useState(null);

    const { value: startDate, setValue: setStartDate } = useInput('');
    const { value: pageSize, setValue: setPageSize } = useInput(1);

    const fetchVerses = async () => {
        if (!startDate.length) {
            setError({ type: "invalidForm", message: "Please enter a Start Date" });
            return;
        };

        const result = await fetch("/api/verses", {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-type': 'application/json'
            },
            body: JSON.stringify({
                startDate: startDate,
                pageSize: parseInt(pageSize)
            })
        });

        setVerses(await result.json());
    };


    if (verses && verses.length) return <VerseResults verses={verses} />

    return (
        <div className="verse-wrapper">
            <div className="verse-panel verse-form-panel">
                <h2 className="verse-panel-header">Fill your day with the Living Word of God</h2>
                <div className="verse-form">
                    <div className="verse-form-inputs">
                        <input onChange={e => setStartDate(e.target.value)} required placeholder="Start Date MM/DD/YY" type="text" name="StartDate" />
                        <input onChange={e => setPageSize(e.target.value)} id="numberverses" required placeholder="Number of Verses" type="number" min="1" name="PageSize" />
                    </div>
                    <button onClick={() => fetchVerses()} className="get-verses-btn" value="Get Verses">Get Verses</button>
                    {error && <p className="verse-form-error">{error.message}</p>}
                </div>
            </div>
        </div>
    );
}
