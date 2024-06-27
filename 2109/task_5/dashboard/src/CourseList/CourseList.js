import React from 'react';
import CourseListRow from './CourseListRow';
import './CourseList.css';
import CourseShape from './CourseShape';
import PropTypes from 'prop-types';

CourseList.propTypes = {
	listCourses: PropTypes.arrayOf(CourseShape),
};

CourseList.defaultProps = {
	listCourses: [],
};

export default function CourseList({ listCourses }) {
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
				{listCourses.length ? (listCourses.map((course) => (
					<CourseListRow key={course.id}
						textFirstCell={course.name}
						textSecondCell={course.credit} />))) : (
					<CourseListRow textFirstCell='No course available yet' />)}
			</tbody>
		</table>
	);
}
