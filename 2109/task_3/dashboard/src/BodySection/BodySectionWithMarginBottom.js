import React from 'react';
import PropTypes from 'prop-types';
import BodySection from './BodySection';
import './BodySection.css';

export default class BodySectionWithMarginBottom extends React.Component {
	render () {
		return (
			<div className='bodySectionWithMargin'>
				<BodySection {...this.props} />
			</div>
		);
	}
}

BodySectionWithMarginBottom.protoTypes = {
	title: PropTypes.string.isRequired,
};
