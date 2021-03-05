import auth0 from 'auth0-js'

export default class Auth {
    constructor(history) {
        this.history = history;
        this.auth0 = new auth0.WebAuth({
            domain: process.env.REACT_APP_AUTH0_DOMAIN,
            clientID: process.env.REACT_APP_AUTH0_CLIENT_ID,
            redirectUri: process.env.REACT_APP_AUTH0_CALLBACK_URL,
            responseType: "code"
        })
    }

    login = () => {
        this.auth0.authorize();
    }

    handleAuthentication = (code) => {

        let tokenUrl = `${process.env.REACT_APP_AUTH0_TOKEN_URL}&` +
            `client_id=${process.env.REACT_APP_AUTH0_CLIENT_ID}&` +
            `client_secret=${process.env.REACT_APP_AUTH0_CLIENT_SECRET}&` +
            `redirect_uri=${process.env.REACT_APP_AUTH0_CALLBACK_URL}&` +
            `code=${code}`;

        fetch(tokenUrl)
            .then(function (response) {
                return response.json();
            })
            .then(function (parsedData) {
                localStorage.setItem("access_token", parsedData.access_token);
                localStorage.setItem("refresh_token", parsedData.refresh_token);
            })
            .catch(console.log)

        this.history.push('/')
    }
}