import React from 'react';
import NotificationItem from './NotificationItem'
import { getLatestNotification } from '../utils/utils'
import PropTypes from 'prop-types';
import NotificationItemShape from "./NotificationItemShape";
import './Notifications.css'
import close from '../assets/close.png'


const Notifications = ({ displayDrawer, listNotifications }) => {

    return (
        <div className='noti'>
            <div className="menuItem">
                Your notifications
            </div>

            {displayDrawer && (
                <div className='Notifications'>

                    <button
                        style={{
                            display: "flex",
                            border: "none",
                            cursor: "pointer",
                            position: "absolute",
                            right: "10px",
                            top: "10px"
                        }}
                        aria-label='close'>
                        <img style={{ width: "15px" }} src={close} alt="button close" />
                    </button>
                    <p>Here is the list of notifications</p>

                    <ul>

                        {listNotifications.length === 0 && (
                            <NotificationItem value="No new notification for now" />
                        )}

                        {listNotifications.map((notification) => (
                            <NotificationItem
                                key={notification.id}
                                type={notification.type}
                                value={notification.value}
                                html={notification.html}
                            />
                        ))}

                        {/* <NotificationItem type="default" value="New course available" />
                        <NotificationItem type="urgent" value="New resume available" />
                        <NotificationItem type="urgent" html={{ __html: getLatestNotification() }} /> */}
                    </ul>


                </div>
            )}
        </div>
    )
};

Notifications.defaultProps = {
    displayDrawer: false,
    listNotifications: [],
  };
  
  Notifications.propTypes = {
    displayDrawer: PropTypes.bool,
    listNotifications: PropTypes.arrayOf(NotificationItemShape),
  };


export default Notifications;