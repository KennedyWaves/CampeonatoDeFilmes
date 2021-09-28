import React from 'react';
import { Route, Switch,Redirect} from 'react-router-dom';
import Selecao from './pages/Selecao';
import Resultado from './pages/Resultado';
import { createBrowserHistory } from "history";
import { Router } from "react-router-dom";

export default function Routes() {
    const history = createBrowserHistory({
        basename: "",
        forceRefresh: false
    })
    return (
        <Router history={history}>
            <Switch>
                <Route exact path="/">
                    <Selecao />
                </Route>
                <Route path="/resultado">
                    <Resultado />
                </Route>
                <Redirect 
                    from="*"
                    to="/"
                />
            </Switch>
        </Router>
    );
}