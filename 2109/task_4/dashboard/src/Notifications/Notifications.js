import React from 'react';
import PropTypes from 'prop-types';
import './Notifications.css';
import NotificationItem from './NotificationItem';
import closeIcon from '../assets/close-icon.png';
import { getLatestNotification } from '../utils/utils';

Notifications.propTypes = {
	displayDrawer: PropTypes.bool,
};

Notifications.defaultProps = {
	displayDrawer: false,
}

export default function Notifications({ displayDrawer }) {
	return (
		<div id="notificationDiv">
			<div className="menuItem">Your Notifications</div>
			{displayDrawer && (
				<div className="Notifications">
					<p>Here is the list of notifications</p>
					<ul>
						<NotificationItem type="default" value="New course available" />
						<NotificationItem type="urgent" value="New resume available" />
						<NotificationItem type="urgent" html={{__html: getLatestNotification() }} />
					</ul>
					<button
						style={{
							border: 0,
							background: 'white',
							position: 'absolute',
							right: '25px',
							top: '25px',
						}}
						aria-label="Close"
						onClick={() => console.log('Close button has been clicked')}>
							<img src={closeIcon} height="15px" width="15px" alt="close icon" />
					</button>
				</div>
			)}
		</div>
	);
}
