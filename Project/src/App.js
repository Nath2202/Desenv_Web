import React, { Component } from 'react';
import Routes from '../src/components/Routes';
import TopNavigation from './components/topNavigation';
import SideNavigation from './components/sideNavigation';
import Footer from './components/Footer';
import './index.css';
import firebase from './utils/Firebase';


class App extends Component {
//   state = {
//     data: []
// };

// componentDidMount() {
//     FirebaseService.getDataList('leituras', (dataReceived) =>    this.setState({data: dataReceived}))
// }
  render() {
    return (
            <div className="flexible-content">
              <TopNavigation />
              <SideNavigation />
              <main id="content" className="p-5">
                <Routes />
              </main>
              <Footer />
            </div>
    );
  }
}


export default App;
