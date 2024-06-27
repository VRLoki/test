import React from 'react';
import WithLogging from './WithLogging';
import Login from '../Login/Login';
import { shallow, configure } from 'enzyme';
import { render } from '@testing-library/react'
import Adapter from 'enzyme-adapter-react-16';
import 'jsdom-global/register';

configure({adapter: new Adapter()});

describe('<WithLogging />', () => {
	it('WithLogging calls console.log on mount with html', () => {
		const spy = jest.spyOn(console, 'log');
		const component = () => <div />;
		const WrappedComponent = WithLogging(component);
		render(<WrappedComponent />);
		expect(spy).toHaveBeenCalledTimes(1);
		expect(spy).toHaveBeenCalledWith(`Component ${component.name} is mounted`);
		spy.mockRestore();
	});

	it('WithLogging calls console.log on mount with <Login />', () => {
		const spy = jest.spyOn(console, 'log');
		const component = () => <Login />;
		const WrappedComponent = WithLogging(component);
		render(<WrappedComponent />);
		expect(spy).toHaveBeenCalledTimes(1);
		expect(spy).toHaveBeenCalledWith(`Component ${component.name} is mounted`);
		spy.mockRestore();
	});

	it('WithLogging calls console.log on unmount with html', () => {
		const spy = jest.spyOn(console, 'log');
		const component = () => <div />;
		const WrappedComponent = WithLogging(component);
		const { unmount } = render(<WrappedComponent />);
		unmount();
		expect(spy).toHaveBeenCalledTimes(2);
		expect(spy).toHaveBeenNthCalledWith(2,
				`Component ${component.name} is going to unmount`);
		spy.mockRestore();
	});

	it('WithLogging calls console.log on unmount with <Login />', () => {
		const spy = jest.spyOn(console, 'log');
		const component = () => <Login />;
		const WrappedComponent = WithLogging(component);
		const { unmount } = render(<WrappedComponent />);
		unmount();
		expect(spy).toHaveBeenCalledTimes(2);
		expect(spy).toHaveBeenNthCalledWith(2,
				`Component ${component.name} is going to unmount`);
		spy.mockRestore();
	});
});
