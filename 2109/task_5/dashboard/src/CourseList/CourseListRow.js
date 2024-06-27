import React from 'react';
import PropTypes from 'prop-types';

CourseListRow.propTypes = {
	isHeader: PropTypes.bool,
	textFirstCell: PropTypes.string.isRequired,
	textSecondCell: PropTypes.oneOfType([PropTypes.string, PropTypes.number]),
};

CourseListRow.defaultProps = {
	isHeader: false,
	textSecondCell: null,
};

const headerStyle = '#deb5b545'

const regularStyle = '#f5f5f5ab'

export default function CourseListRow ({ isHeader, textFirstCell,
																				 textSecondCell}) {
		return (
			<tr style={{ backgroundColor: isHeader ? headerStyle : regularStyle}}>
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
