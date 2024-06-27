import { shallow } from 'enzyme';
import Notification from "./Notifications";

describe('<MyComponent />', () => {
  it('renders app', () => {
    const wrapper = shallow(<Notification />);
    expect(wrapper.exists);
  });

  it('renders App-header', () => {
    const wrapper = shallow(<Notification />);
    expect(wrapper.find('ul')).to.have.lengthOf(1);
    expect(wrapper.find('li')).to.have.lengthOf(3);
  });

  it('renders App-body', () => {
    const { getByText } = within(screen.getByTestId('Notifications'))
    expect(getByText('Here is the list of notifications')).toBeInTheDocument()
  });

  it('renders App-footer', () => {
    const wrapper = shallow(<App />);
    expect(wrapper.find("App-footer")).toEqual("App-footer");
  });
});