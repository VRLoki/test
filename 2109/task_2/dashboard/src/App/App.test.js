import App from './App';
import React from 'react';
import { shallow, configure } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';

configure({adapter: new Adapter()});

describe('<App />', () => {
	it('App renders w/o crashing', () => {
		const wrapper = shallow(<App />);
		expect(wrapper.exists()).toBe(true);
	});

	it('Notifications renders', () => {
		const wrapper = shallow(<App />);
		expect(wrapper.find('Notifications').exists()).toBe(true);
	});

	it('Header renders', () => {
		const wrapper = shallow(<App />);
		expect(wrapper.find('Header').exists()).toBe(true);
	});

	it('Login renders', () => {
		const wrapper = shallow(<App />);
		expect(wrapper.find('Login').exists()).toBe(true);
	});

	it('Footer renders', () => {
		const wrapper = shallow(<App />);
		expect(wrapper.find('Footer').exists()).toBe(true);
	});
})
