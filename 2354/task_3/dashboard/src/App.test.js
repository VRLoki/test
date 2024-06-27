import { shallow } from 'enzyme';

describe('<MyComponent />', () => {
  it('renders app', () => {
    const wrapper = shallow(<App />);
    expect(wrapper.find("App-header")).toEqual("App-header");
  });

  it('renders App-header', () => {
    const wrapper = shallow(<App />);
    expect(wrapper.find("App")).toEqual("App");
  });

  it('renders App-body', () => {
    const wrapper = shallow(<App />);
    expect(wrapper.find("App-body")).toEqual("App-body");
  });

  it('renders App-footer', () => {
    const wrapper = shallow(<App />);
    expect(wrapper.find("App-footer")).toEqual("App-footer");
  });
});