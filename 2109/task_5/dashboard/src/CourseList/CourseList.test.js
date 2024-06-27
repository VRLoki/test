import React from 'react';
import CourseList from './CourseList';
import { shallow, configure } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';

configure({adapter: new Adapter()});

const listCourses = [
	{ id: '1', name: 'ES6', credit: 60},
	{ id: '2', name: 'Webpack', credit: 20},
	{ id: '3', name: 'React', credit: 40},
]

describe('CourseList', () => {
	it('CourseList renders w/o crashing & renders 5 CourseListRow items', () => {
		const wrapper = shallow(
			<CourseList listCourses={listCourses}/>);
		expect(wrapper.find('CourseListRow').length).toBe(5);
	});

	it('CourseList renders correctly when listCourses=[]', () => {
		const wrapper = shallow(
			<CourseList listCourses={[]} />);
		expect(wrapper.find('CourseListRow').length).toBe(3);
		expect(wrapper.find('CourseListRow').last().props().textFirstCell).toBe(
			'No course available yet'
		);
	});
});
