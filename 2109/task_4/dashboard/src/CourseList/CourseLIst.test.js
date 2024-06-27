import React from 'react';
import CourseList from './CourseList';
import { shallow, configure } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';

configure({adapter: new Adapter()});

describe('CourseList', () => {
	it('CourseList renders w/o crashing & renders 5 CourseListRow items', () => {
		const wrapper = shallow(<CourseList />);
		expect(wrapper.find('CourseListRow').length).toBe(5);
	});
});
