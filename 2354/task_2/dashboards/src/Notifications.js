import React from 'react';
import './Notifications.css';
import { getLatestNotification } from './utils';

function Notifications() {
    return (
      <div className="Notifications">
        <p>Here is the list of notifications</p>
        <button aria-label='Close' onClick={buttonclc()} style={btncs}>
          <img src='close-icon'></img>
        </button>
        <ul>
          <li data-priority="default">New course available</li>
          <li data-priority="default">New resume available</li>
          <li data-priority="high" dangerouslySetInnerHTML={{ __html: getLatestNotification() }}></li>
        </ul>
      </div>
    );
  }
  function buttonclc(){
    console.log("Close button has been clicked");
}
const btncs = {
    position: 'fixed',
    float: 'right',
    background: 'transparent',
	  color: 'white',
    top: '10px',
    right: '10px',
    height: '17px'
}
export default Notifications;


  