import React from 'react';
import { shallow, configure } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';
import BodySectionWithMarginBottom from './BodySectionWithMarginBottom';
import 'jsdom-global/register';

configure({adapter: new Adapter()});

describe('<BodySectionWithMarginBottom />', () => {
	it('BodySectionWithMarginBottom renders w/o crashing', () => {
		const wrapper = shallow(<BodySectionWithMarginBottom />);
		expect(wrapper.exists()).toBe(true);
	});

	it('BSWMB renders BodySection and children', () => {
		const wrapper = shallow(<BodySectionWithMarginBottom title="title">
				<p>Lorem Ipsum</p>
			</BodySectionWithMarginBottom>);
		const bodySection = wrapper
			.findWhere(n => n.prop('title') === 'title');
		expect(bodySection.length).toBe(1);
	});
});
