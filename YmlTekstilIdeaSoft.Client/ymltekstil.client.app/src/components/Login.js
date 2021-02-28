import React, { Component } from 'react';

class Login extends Component {

    componentDidMount() {
        this.props.auth.login();
    }

    render() {
        return (
            <div className="centerInMiddle">
                <h1>
                    Yönlendiriliyorsunuz . . .
            </h1>
            </div>
        );
    }
}

export default Login;