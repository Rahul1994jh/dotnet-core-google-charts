import React from 'react'
import Chart from './Charts'
import axios from "axios"

class App extends React.Component {

    state = { data: "default message" }

    componentDidMount() {

        const url = "http://localhost:35677/api/SalesVisualizer"

        axios.get(url)
            .then((response) => {
                this.setState({
                    data: response.data
                })
            })

        console.log(this.state.data);

    }


    render() {
        return <div>
            <Chart chart={this.state.data} />
        </div>
    }
}


export default App;