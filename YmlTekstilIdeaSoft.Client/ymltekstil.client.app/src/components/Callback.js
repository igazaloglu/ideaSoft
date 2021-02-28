import React, { Component } from 'react';
import url from 'url';

class Callback extends Component {

    componentDidMount = () => {
        let urlObject = url.parse(this.props.location.search, true)

        if (urlObject.query['code']) {
            this.props.auth.handleAuthentication(urlObject.query['code']);
        }
        else 
        {
            throw new Error("Invalid Callback url");
        }
    }

    render() {
        return (
            <h1>
                Loading . . .
            </h1>
        );
    }
}


export default Callback;