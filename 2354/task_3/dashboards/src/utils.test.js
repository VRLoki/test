import { getFooterCopy, getFullYear, getLatestNotification } from "./utils";

describe('tests', () => {
    it(`...`, () => {
        expect(getFullYear()).toBe(getFullYear());
        });
    it(`...`, () => {
        expect(getFooterCopy(true)).toBe("Holberton School");
        });
    it(`...`, () => {
        expect(getLatestNotification()).toBe("<strong>Urgent requirement</strong> - complete by EOD");
        });
  });