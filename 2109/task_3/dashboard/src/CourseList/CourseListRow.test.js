import React from 'react';
import CourseListRow from './CourseListRow';
import { shallow, configure } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';

configure({adapter: new Adapter()});

describe('CourseListRow', () => {
	it('CourseListRow renders w/o crashing', () => {
		const wrapper = shallow(<CourseListRow textFirstCell="First cell"/>);
		expect(wrapper.exists()).toBe(true);
	});

	it('CourseListRow renders one cell w/colSpan=2 when textSecondCell=false', () => {
		const wrapper = shallow(
			<CourseListRow textFirstCell="First cell" isHeader={true}/>);
		expect(wrapper.find('th').length).toBe(1);
		expect(wrapper.find('th').text()).toBe("First cell");
		expect(wrapper.find('th').prop('colSpan')).toBe(2);
	});

	it('CourseListRow renders one cell w/colSpan=2 when textSecondCell=false', () => {
		const wrapper = shallow(
			<CourseListRow
				textFirstCell="First cell"
				isHeader={true}
				textSecondCell="Second cell"/>);
		expect(wrapper.find('th').length).toBe(2);
	});
});
