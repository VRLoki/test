import { getFullYear, getFooterCopy, getLatestNotification } from './utils';

test('getFullYear returns correct year', () => {
  expect(getFullYear()).toBe(2023);
});

test('getFooter if false', () => {
  expect(getFooterCopy()).toBe('Holberton School main dashboard');
});

test('getFooter if true', () => {
	expect(getFooterCopy(true)).toBe('Holberton School');
});

test('getLatestNotification', () => {
  expect(getLatestNotification()).toBe('<strong>Urgent requirement</strong> - complete by EOD');
});
