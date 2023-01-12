import React, { useState, useEffect } from 'react';
import Chart from './Charts';


const getData = async () => {
    try {
        const response = await fetch(
            `/salesVisualizer`
        );
        if (!response.ok) {
            throw new Error(
                `This is an HTTP error: The status is ${response.status}`
            );
        }
        let actualData = await response.json();
        console.log(actualData);
        return actualData;
        setError(null);
    } catch (err) {
        setError(err.message);
        setData(null);
    } finally {
        setLoading(false);
    }
}


function ShowCharts() {

    const [show, setShow] = useState(false);
    const [data, setData] = useState(false);

    const sale = getData();

    useEffect(() => {
        setData(sale);
    }, [show])

    return (
        <div className="App">
            Hi
        </div>
    );
}

export default ShowCharts;