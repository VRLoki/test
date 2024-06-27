import React from 'react';
import Notifications from './Notifications';
import { shallow, configure } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';
import { getLatestNotification } from '../utils/utils';

configure({adapter: new Adapter()});

const listNotifications = [
	{ id: 1, type: 'default', value: 'New course available' },
	{ id: 2, type: 'urgent', value: 'New resume available' },
	{ id: 3, type: 'urgent', html: { __html: getLatestNotification() } },
]

describe('Notifications', () => {
	it('Notifications renders w/o crashing', () => {
		const wrapper = shallow(<Notifications />);
		expect(wrapper.exists()).toBe(true);
	});

	it('Notifications renders properly when displayDrawer=false', () => {
		const wrapper = shallow(<Notifications />);
		const menuItem = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'menuItem');
		const notificationsItem = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'Notifications');
		expect(menuItem.length).toBe(1);
		expect(notificationsItem.length).toBe(0);
	});

	it('Notifications renders properly when displayDrawer=true', () => {
		const wrapper = shallow(<Notifications displayDrawer={true}/>);
		const menuItem = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'menuItem');
		const notificationsItem = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'Notifications');
		expect(menuItem.length).toBe(1);
		expect(notificationsItem.length).toBe(1);
	});

	it('Notifications renders 3 NotificationItem elements', () => {
		const wrapper = shallow(
			<Notifications displayDrawer={true} listNotifications={listNotifications}/>);
		expect(wrapper.find('NotificationItem').length).toBe(3);
	});

	it('Notifications renders proper string', () => {
		const wrapper = shallow(
			<Notifications displayDrawer={true} listNotifications={listNotifications}/>);
		expect(wrapper.find(
			'NotificationItem')
			.first().props().value).toEqual('New course available');
	});

	it('Notifications renders correctly when listNotifications=[]', () => {
		const wrapper = shallow(
			<Notifications displayDrawer={true} listNotifications={[]} />);
		const menuItem = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'menuItem');
		const notificationsItem = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'Notifications');
		const noNewItems = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'Notifications')
			.find('p');
		expect(menuItem.length).toBe(1);
		expect(notificationsItem.length).toBe(1);
		expect(noNewItems.text()).toEqual('No new notification for now');
	});

	it('Notifications renders correctly when !listNotifications', () => {
		const wrapper = shallow(
			<Notifications displayDrawer={true} />);
		const menuItem = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'menuItem');
		const notificationsItem = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'Notifications');
		const noNewItems = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'Notifications')
			.find('p');
		expect(menuItem.length).toBe(1);
		expect(notificationsItem.length).toBe(1);
		expect(noNewItems.text()).toEqual('No new notification for now');
	});

	it('Notifications renders correctly when listNotifications is set', () => {
		const wrapper = shallow(
			<Notifications displayDrawer={true} listNotifications={listNotifications}/>);
		const menuItem = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'menuItem');
		const notificationsItem = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'Notifications');
		const hereItem = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'Notifications')
			.find('p');
		const notifsList = wrapper
			.findWhere(n => n.prop('id') === 'notificationDiv')
			.findWhere(n => n.prop('className') === 'Notifications')
			.find('NotificationItem');
		expect(menuItem.length).toBe(1);
		expect(notificationsItem.length).toBe(1);
		expect(hereItem.text()).toEqual('Here is the list of notifications');
		expect(notifsList.length).toBe(3);
	});
});

