import React from 'react';
import Notifications from './Notifications';
import { shallow, configure } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';

configure({adapter: new Adapter()});
describe('Notifications', () => {
	it('Notifications renders w/o crashing', () => {
		const wrapper = shallow(<Notifications />);
		expect(wrapper.exists()).toBe(true);
	});

	it('Notifications renders 3 list items', () => {
		const wrapper = shallow(<Notifications />);
		expect(wrapper.find('li').length).toBe(3);
	});

	it('Notifications renders proper string', () => {
		const wrapper = shallow(<Notifications />);
		expect(wrapper.find('p').text()).toBe('Here is the list of notifications');
	});
});
