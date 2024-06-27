import './App.css';
import { getFullYear,getFooterCopy } from './utils';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img className="App-Logo" alt='' src={require('./logo.jpg')} />
        <h1>School dashboard</h1>
      </header>
      <body className="App-body">
      <p>Login to access the full dashboard</p>
      <label>Email: </label>
      <input type='email'></input>
      <label>Password: </label>
      <input type='password'></input>
      <button>OK</button>
      </body>
      <footer className="App-footer">
      <p>Copyright {getFullYear()} - {getFooterCopy(true)}</p>
      </footer>
    </div>
  );
}

export default App;
