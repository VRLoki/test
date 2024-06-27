import Footer from './Footer';
import React from 'react';
import { shallow, configure } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';

configure({adapter: new Adapter()});

describe('Footer', () => {
	it('Footer renders w/o crashing', () => {
		const wrapper = shallow(<Footer />);
		expect(wrapper.exists()).toBe(true);
	});

	it('Footer renders the word "Copyright"', () => {
		const wrapper = shallow(<Footer />);
		expect(wrapper.find('p').text()).toContain('Copyright');
	});
});
