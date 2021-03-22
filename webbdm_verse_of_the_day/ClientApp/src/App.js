import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Favorites } from './components/Favorites';
import { VerseResults } from './components/VerseResults';

import './custom.css'


export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/results' component={VerseResults} />
        <Route path='/favorites' component={Favorites} />
      </Layout>
    );
  }
}
