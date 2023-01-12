import React from 'react';
import { Chart } from "react-google-charts";

export const options = {
    title: "My Daily Activities",
};

const charts = (props) => {
    console.log(props.chart)

    return (

         <div>hi</div>
        //<Chart
        //    chartType='PieChart'
        //    data={props.chart}
        //    options={options}
        //    width={"100%"}
        //    height={"400px"}
        ///>
    )
}

export default charts;