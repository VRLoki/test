import React from 'react';

const WithLogging = (WrappedComponent) => {
	const name =
		WrappedComponent.name || 'Component';

	class Logger extends React.Component {
		componentDidMount() {
			console.log(`Component ${name} is mounted`);
		}

		componentWillUnmount() {
			console.log(`Component ${name} is going to unmount`);
		}

		render () {
			return <WrappedComponent {...this.props} />;
		}
	}
	Logger.displayName = `WithLogging(${name})`;
	return Logger;
};

export default WithLogging;
