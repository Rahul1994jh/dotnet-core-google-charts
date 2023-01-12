import { Chart } from "react-google-charts";

const charts = (props) => {
    return (
        <Chart
            chartType={props.chart.chartType}
            data={props.chart.data}
            options={props.chart.options}
            width={props.chart.width}
            height={props.chart.height}
        />
    )
}

export default charts;