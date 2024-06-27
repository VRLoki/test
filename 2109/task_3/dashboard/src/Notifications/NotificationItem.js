import React from 'react';
import PropTypes from 'prop-types';

NotificationItem.propTypes = {
	type: PropTypes.string,
	value: PropTypes.string,
	html: PropTypes.shape({
		__html: PropTypes.string,
	}),
};

NotificationItem.defaultProps = {
	type: 'default',
}

export default function NotificationItem({type, html, value}) {
	if (value) {
		return <li data-priority={type}>{value}</li>;
	}
	return <li data-priority={type} dangerouslySetInnerHTML={html} />;
}
