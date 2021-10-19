import * as React from 'react';
import { Route } from 'react-router';
import Home from './components/Home';
import Header from './components/Layout/Header';
import './custom.css'

export default () => (
    <Header>
        <Route exact path='/' component={Home} />
    </Header>
);
