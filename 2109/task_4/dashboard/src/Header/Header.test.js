import Header from './Header';
import React from 'react';
import { shallow, configure } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';

configure({adapter: new Adapter()});

describe('Header', () => {
	it('Header renders w/o crashing', () => {
		const wrapper = shallow(<Header />);
		expect(wrapper.exists()).toBe(true);
	});

	it('Header renders img and h1', () => {
		const wrapper = shallow(<Header />);
		expect(wrapper.find('img').exists()).toBe(true);
		expect(wrapper.find('h1').exists()).toBe(true);
	});
});
