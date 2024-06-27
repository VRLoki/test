import React from 'react';
import './Login.css';

function Login() {
  return (
		<React.Fragment>
			<div className="App-body">
				<p>Login to access the full dashboard</p>
				<form className="Form-body">
					<label htmlFor="email">
						Email:
						<input type="email" id="email" name="email" />
					</label>
					<label htmlFor="password">
						Password:
						<input type="password" id="password" name="password" />
					</label>
					<input type="submit" value="OK" />
				</form>
			</div>
		</React.Fragment>
  );
}

export default Login;
