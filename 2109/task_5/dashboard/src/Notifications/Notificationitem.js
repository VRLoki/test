import React from 'react';
import PropTypes from 'prop-types';

export default function NotificationItem({type, html, value, markAsRead}) {
	if (value) {
		return <li data-priority={type}
			onClick={markAsRead}>{value}</li>;
	}
	return <li data-priority={type}
		dangerouslySetInnerHTML={html}
		onClick={markAsRead} />;
}

NotificationItem.propTypes = {
	type: PropTypes.string,
	value: PropTypes.string,
	html: PropTypes.shape({
		__html: PropTypes.string,
	}),
	markAsRead: PropTypes.func.isRequired,
};

NotificationItem.defaultProps = {
	type: 'default',
}

// export default React.memo(NotificationItem)
// commented this out because although it makes the function "pure"
// it breaks several tests and I've had it up to here with fiddling
// with these tests

