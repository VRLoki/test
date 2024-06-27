import React from 'react';
import { shallow, configure } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';
import BodySection from './BodySection';

configure({adapter: new Adapter()});

describe('<BodySection />', () => {
	it('BodySection renders w/o crashing', () => {
		const wrapper = shallow(<BodySection />);
		expect(wrapper.exists()).toBe(true);
	});

	it('BodySection renders h2 with title and children', () => {
		const wrapper = shallow(<BodySection title="title">
				<p>Lorem Ipsum</p>
			</BodySection>);
		expect(wrapper.find('h2').exists()).toBe(true);
		expect(wrapper.find('p').exists()).toBe(true);
		expect(wrapper.find('p').text()).toBe('Lorem Ipsum');
	});
});
