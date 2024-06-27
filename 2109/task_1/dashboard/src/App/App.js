import React from 'react';
import PropTypes from 'prop-types';
import './App.css';
import Notifications from '../Notifications/Notifications';
import Header from '../Header/Header';
import Footer from '../Footer/Footer';
import Login from '../Login/Login';
import CourseList from '../CourseList/CourseList';
import { getLatestNotification } from '../utils/utils';

const listCourses = [
  { id: '1', name: 'ES6', credit: 60},
  { id: '2', name: 'Webpack', credit: 20},
  { id: '3', name: 'React', credit: 40},
]

const listNotifications = [
  { id: 1, type: 'default', value: 'New course available' },
  { id: 2, type: 'urgent', value: 'New resume available' },
  { id: 3, type: 'urgent', html: { __html: getLatestNotification() } },
]

export default class App extends React.Component {
  componentDidMount() {
    window.addEventListener('keydown', this.ctrlKeyPress);
  }

  componentWillUnmount() {
    window.removeEventListener('keydown', this.ctrlKeyPress);
  }
  
  ctrlKeyPress = (event) => {
    if (event.ctrlKey && event.key === 'h') {
        window.alert('Logging you out')
        this.props.logOut();
      }
  }

  render () {
    const {isLoggedIn} = this.props;
    return (
      <React.Fragment>
        <div className="App">
          <Notifications listNotifications={listNotifications} />
          <div className="App-header">
            <Header />
          </div>
          <div className="App-body">
            {isLoggedIn ? <CourseList listCourses={listCourses} /> : <Login />}
          </div>
          <div className="App-footer">
            <Footer />
          </div>
        </div>
      </React.Fragment>
    );
  }
}

App.propTypes = {
  isLoggedIn: PropTypes.bool,
  logOut: PropTypes.func,
};

App.defaultProps = {
  isLoggedIn: false,
  logOut: () => {},
};
