import React from 'react';
import PropTypes from 'prop-types';

CourseListRow.propTypes = {
	isHeader: PropTypes.bool,
	textFirstCell: PropTypes.string.isRequired,
	textSecondCell: PropTypes.string,
};

CourseListRow.defaultProps = {
	isHeader: false,
	textSecondCell: null,
};

export default function CourseListRow ({ 
	isHeader,
	textFirstCell,
	textSecondCell}) {
		return (
			<tr>
				{isHeader && textSecondCell === null && (
					<th colSpan={2}>{textFirstCell}</th>
				)}
				{isHeader && textSecondCell && (
					<>
						<th>{textFirstCell}</th>
						<th>{textSecondCell}</th>
					</>
				)}
				{!isHeader && (
					<>
						<td>{textFirstCell}</td>
						<td>{textSecondCell}</td>
					</>
				)}
			</tr>
	)
}
