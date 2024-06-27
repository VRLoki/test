import React from 'react';
import CourseListRow from './CourseListRow';
import './CourseList.css';

export default function CourseList() {
	return (
		<table id="CourseList">
			<thead>
				<CourseListRow textFirstCell='Available courses' isHeader={true} />
				<CourseListRow
					textFirstCell='Course name'
					isHeader={true}
					textSecondCell='Credit' />
			</thead>
			<tbody>
				<CourseListRow
					textFirstCell='ES6'
					isHeader={false}
					textSecondCell='60' />
				<CourseListRow
					textFirstCell='Webpack'
					isHeader={false}
					textSecondCell='20' />
				<CourseListRow
					textFirstCell='React'
					isHeader={false}
					textSecondCell='40' />
			</tbody>
		</table>
	);
}
