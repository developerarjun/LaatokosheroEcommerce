import * as React from 'react';
import { connect } from 'react-redux';
import Header from './Layout/Header';

const Home = () => (
  <div>
    <Header>
    </Header>
  </div>
);

export default connect()(Home);
