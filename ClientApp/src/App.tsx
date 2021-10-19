import * as React from 'react';
import { Route } from 'react-router';
import { BrowserRouter as Router, Link, Switch } from 'react-router-dom';
import Home from './components/Home';
import Login from './components/SuperAdmin/Login.js';
import './custom.css'

export default () => (
    <Router>
    <Switch>
        <Route exact path='/' component={Home} />
        <Route exact path='/modules/public/login' component={Login} />
    </Switch>
    </Router>
);
