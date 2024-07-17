# Unittests in JS
![JavaScript](https://img.shields.io/badge/-JavaScript-F7DF1E?style=flat-square&logo=javascript&logoColor=black)
![Mocha](https://img.shields.io/badge/-Mocha-8D6748?style=flat-square&logo=mocha&logoColor=white)
![Chai](https://img.shields.io/badge/-Chai-A30701?style=flat-square&logo=chai&logoColor=white)
![Express](https://img.shields.io/badge/-Express-000000?style=flat-square&logo=express&logoColor=white)
![Sinon](https://img.shields.io/badge/-Sinon-C53635?style=flat-square&logo=sinon.js&logoColor=white)

![image](https://github.com/v-dav/holbertonschool-web_back_end/assets/115344057/55c2c72d-26d9-4aef-ad3b-3ec5b56e945f)


## 🧐 Project Description:

The "Unittests in JS" project is focused on understanding and implementing unit tests in JavaScript using popular testing frameworks and libraries like Mocha, Chai, and Sinon. The project aims to provide hands-on experience with writing and executing test suites, assertions, and mocks in JavaScript applications. Below are the key details of the project:

## 📖 Learning Objectives:
  - Learn how to write test suites using Mocha.
  - Understand different assertion libraries such as Node.js assert module and Chai.
  - Explore the usage of spies and stubs in testing scenarios.
  - Learn about hooks and their significance in test suites.
  - Gain knowledge about unit testing asynchronous functions.
  - Understand how to write integration tests for a small Node.js server.

## ⚙️ Resources:

To deepen your understanding of unit testing in JavaScript, refer to the following resources:

- **Read or Watch**:
  - [Mocha documentation](https://mochajs.org/)
  - [Chai documentation](https://www.chaijs.com/api/)
  - [Sinon documentation](https://sinonjs.org/)
  - [Express documentation](https://expressjs.com/)
  - [Request documentation](https://www.npmjs.com/package/request)

# 🍵 Mocha
Mocha is a popular testing framework for JavaScript, often used in conjunction with other libraries like Chai for assertions. Here's a simple guide on how to write a test suite using Mocha with some basic examples:

### Step 1: Installation
First, ensure you have Node.js installed on your system. Then, you can install Mocha globally or locally in your project:

```bash
npm install --global mocha
# or
npm install --save-dev mocha
```

### Step 2: Setting up your test files
Create a directory for your tests (e.g., `test/`) and place your test files inside it. Each test file typically ends with `.test.js` or `.spec.js`.

### Step 3: Writing test cases
Let's say we have a simple JavaScript function `add` that adds two numbers:

```javascript
// add.js
function add(a, b) {
  return a + b;
}

module.exports = add;
```

Now, let's write tests for this function.

```javascript
// test/add.test.js

// Importing the assert module from Node.js
const assert = require('assert');

// Importing the add function
const add = require('../add');

// Describe block defines a test suite
describe('Addition', function() {
  // It block defines a test case
  it('should add two numbers correctly', function() {
    // Assertion
    assert.strictEqual(add(1, 2), 3);
  });

  it('should return 0 when adding 0 to any number', function() {
    assert.strictEqual(add(0, 5), 5);
    assert.strictEqual(add(0, -5), -5);
    assert.strictEqual(add(0, 0), 0);
  });

  it('should handle negative numbers correctly', function() {
    assert.strictEqual(add(-1, -2), -3);
  });
});
```

### Step 4: Running tests
Now, you can run your tests using the Mocha command in your terminal:

```bash
mocha
```

Mocha will look for test files in the `test/` directory and execute them. You'll see the test results in your terminal.

That's it! You've created a simple test suite using Mocha with some basic examples. You can extend this setup by adding more test cases and using other features provided by Mocha and assertion libraries like Chai.

# ☕️ Chai
Chai is an assertion library that works very well with Mocha, providing a more expressive way to write assertions compared to Node.js's built-in `assert` module. Here's how you can use Chai with Mocha, continuing with the previous example:

### Step 1: Installation
If you haven't already installed Chai, you can do so using npm:

```bash
npm install --save-dev chai
```

### Step 2: Updating test files
Modify your test files to use Chai assertions instead of Node.js's built-in `assert`.

```javascript
// test/add.test.js

// Importing Chai assertion styles
const { expect } = require('chai');

// Importing the add function
const add = require('../add');

// Describe block defines a test suite
describe('Addition', function() {
  // It block defines a test case
  it('should add two numbers correctly', function() {
    // Assertion using Chai
    expect(add(1, 2)).to.equal(3);
  });

  it('should return 0 when adding 0 to any number', function() {
    // Multiple assertions in one test case
    expect(add(0, 5)).to.equal(5);
    expect(add(0, -5)).to.equal(-5);
    expect(add(0, 0)).to.equal(0);
  });

  it('should handle negative numbers correctly', function() {
    // Another assertion using Chai
    expect(add(-1, -2)).to.equal(-3);
  });
});
```

### Step 3: Running tests
You can still use Mocha to run your tests as before:

```bash
mocha
```

### Summary
Chai provides a more fluent and expressive way to write assertions in your tests compared to Node.js's built-in `assert` module. By combining Chai with Mocha, you can create more readable and maintainable test suites for your JavaScript code.


# 🚀 How to present long test suites
Presenting long test suites effectively is crucial for maintaining readability and understanding. Here are some strategies to accomplish this:

### 1. Grouping Tests
Break down your tests into logical groups using `describe` blocks. Each `describe` block should encapsulate related tests, making it easier to understand the purpose of each test suite.

```javascript
describe('Math Operations', function() {
  // Tests for addition
  describe('Addition', function() {
    // Individual test cases for addition
  });

  // Tests for subtraction
  describe('Subtraction', function() {
    // Individual test cases for subtraction
  });

  // Other math operations...
});
```

### 2. Descriptive Test Names
Use descriptive names for your tests and test suites. This helps in quickly understanding what each test is checking without needing to delve into the code.

```javascript
it('should add two positive numbers correctly', function() {
  // Test implementation
});
```

### 3. Comments and Documentation
Include comments where necessary to explain the purpose of each test or test suite. Documentation can also be beneficial, especially for complex test suites, to provide context and explain the reasoning behind certain tests.

```javascript
// This test suite checks the behavior of the add function
describe('Addition', function() {
  // This test verifies that positive numbers are added correctly
  it('should add two positive numbers correctly', function() {
    // Test implementation
  });
});
```

### 4. Test Coverage Reports
Use tools like Istanbul or built-in coverage tools in test runners to generate test coverage reports. These reports provide insights into which parts of your codebase are covered by tests, helping you ensure comprehensive test coverage while also identifying areas where tests may be lacking.

### 5. Separate Files for Large Suites
If your test suite becomes excessively large, consider splitting it into multiple files. Organize tests based on functionality, features, or modules. This approach prevents individual test files from becoming unwieldy and improves maintainability.

### 6. Test Hooks
Utilize Mocha's `before`, `beforeEach`, `after`, and `afterEach` hooks to set up and tear down test fixtures. This ensures that common setup and teardown tasks are performed consistently across multiple tests.

```javascript
describe('Database Operations', function() {
  let dbConnection;

  before(function() {
    // Establish database connection
    dbConnection = connectToDatabase();
  });

  after(function() {
    // Close database connection
    dbConnection.close();
  });

  // Tests for database CRUD operations...
});
```

By following these strategies, you can present long test suites in a structured and understandable manner, facilitating easier maintenance, debugging, and collaboration within your development team.

# 🕵️‍♂️ Spies
Spies are a testing utility provided by libraries like Sinon.js, Jasmine, or Jest. They allow you to observe the behavior of functions, such as whether they were called, with what arguments, and how many times. Spies are particularly useful when you want to test interactions between different parts of your code or verify that certain functions are being called as expected.

### When to use spies:

1. **Verifying Function Calls**: You can use spies to ensure that a function is being called during the execution of your code.

2. **Testing Callbacks**: When testing asynchronous code that relies on callbacks, spies can help verify that the callback functions are called correctly.

3. **Mocking Functions**: Spies can also be used to replace existing functions with a test implementation, allowing you to control their behavior during testing.

### How to use spies:

Let's consider a simple example where we have a function that makes an HTTP request and then calls a callback function with the result:

```javascript
// http.js
const axios = require('axios');

function fetchData(callback) {
  axios.get('https://api.example.com/data')
    .then(response => {
      callback(response.data);
    })
    .catch(error => {
      callback(null, error);
    });
}

module.exports = fetchData;
```

Now, we want to test if the `fetchData` function correctly calls the callback with the fetched data. We can use a spy to observe this behavior:

```javascript
// test/http.test.js
const axios = require('axios');
const sinon = require('sinon');
const fetchData = require('../http');

describe('HTTP Requests', function() {
  it('should call the callback with fetched data', function() {
    // Create a spy to observe the callback function
    const callbackSpy = sinon.spy();

    // Stub the axios.get function to return a resolved promise with mock data
    const axiosStub = sinon.stub(axios, 'get').resolves({ data: 'Mock Data' });

    // Call the function under test
    fetchData(callbackSpy);

    // Verify that axios.get was called with the correct URL
    sinon.assert.calledWith(axios.get, 'https://api.example.com/data');

    // Verify that the callback was called with the fetched data
    sinon.assert.calledWith(callbackSpy, 'Mock Data');

    // Restore the original behavior of axios.get
    axiosStub.restore();
  });
});
```

In this example:
- We create a spy using `sinon.spy()` to observe the callback function.
- We stub the `axios.get` function using `sinon.stub()` to return a resolved promise with mock data.
- We call the `fetchData` function with the spy as the callback.
- We use `sinon.assert.calledWith()` to verify that `axios.get` was called with the correct URL and that the callback was called with the fetched data.
- Finally, we restore the original behavior of `axios.get` using `axiosStub.restore()`.

This is a basic example of how spies can be used to observe and verify function calls during testing. They provide a powerful tool for testing interactions between different parts of your code and ensuring that your functions behave as expected.

# 🛠️ Stubs

Stubs are a testing utility commonly used in test-driven development (TDD) or unit testing. They replace certain parts of your code with simplified implementations that you control during tests. Stubs are useful when you want to isolate the code under test from its dependencies, such as external services or complex subsystems.

### When to use stubs:

1. **Isolating Dependencies**: When testing a unit of code that relies on external services, databases, or complex subsystems, stubs can be used to replace these dependencies with simplified implementations. This allows you to focus solely on testing the behavior of the unit without worrying about the behavior of its dependencies.

2. **Controlling Behavior**: Stubs allow you to control the behavior of certain functions or modules during tests. You can specify how stubbed functions should behave, what values they should return, or what errors they should throw.

3. **Simulating Conditions**: Stubs can simulate different conditions or scenarios that might be difficult to reproduce in real-world environments, such as network failures, timeouts, or specific error conditions.

### How to use stubs:

Let's consider an example where we have a function that retrieves user data from a database:

```javascript
// user.js
const database = require('./database');

function getUserData(userId) {
  return database.getUser(userId);
}

module.exports = getUserData;
```

In our test, we want to isolate the `getUserData` function from the actual database and provide it with controlled responses using a stub:

```javascript
// test/user.test.js
const sinon = require('sinon');
const getUserData = require('../user');
const database = require('../database');

describe('getUserData', function() {
  it('should return user data from the database', function() {
    // Stub the database.getUser function
    const databaseStub = sinon.stub(database, 'getUser');
    
    // Specify the response that the stub should return
    databaseStub.withArgs(123).returns({ id: 123, name: 'John Doe', email: 'john@example.com' });
    
    // Call the function under test
    const userData = getUserData(123);
    
    // Verify the result
    assert.deepEqual(userData, { id: 123, name: 'John Doe', email: 'john@example.com' });
    
    // Restore the original behavior of the stubbed function
    databaseStub.restore();
  });
});
```

In this example:
- We use `sinon.stub()` to create a stub for the `database.getUser` function.
- We use `stub.withArgs()` to specify the arguments for which the stub should return a particular value.
- We call the function under test (`getUserData`) with the stubbed database function.
- We verify that the function returns the expected result.
- Finally, we restore the original behavior of the stubbed function using `stub.restore()` to avoid affecting other tests.

Stubs provide a flexible way to control the behavior of dependencies during tests, allowing you to simulate different scenarios and isolate the code under test. However, it's essential to use stubs judiciously and avoid overuse, as excessive stubbing can make tests less reliable and harder to maintain.

# 🪝 Hooks

Hooks are functions provided by testing frameworks like Mocha or Jest that allow you to run code before or after tests or test suites. They are useful for setting up test fixtures, tearing down resources, or performing common setup and cleanup tasks.

### Common hooks provided by testing frameworks:

1. **Before All (Mocha) / BeforeAll (Jest)**:
   - Runs once before all tests in the test suite.
   - Used for setting up common resources or performing global setup tasks.

2. **Before Each (Mocha) / BeforeEach (Jest)**:
   - Runs before each test in the test suite.
   - Used for setting up test fixtures or performing setup tasks specific to each test.

3. **After Each (Mocha) / AfterEach (Jest)**:
   - Runs after each test in the test suite.
   - Used for cleaning up resources or performing teardown tasks specific to each test.

4. **After All (Mocha) / AfterAll (Jest)**:
   - Runs once after all tests in the test suite.
   - Used for performing global cleanup tasks or tearing down common resources.

### When to use hooks:

1. **Setting up Test Fixtures**: Use `beforeEach` to set up any common fixtures or test data that multiple tests will use. This ensures that each test starts with a consistent environment.

2. **Tearing Down Resources**: Use `afterEach` to clean up any resources or reset any changes made during the test. This prevents tests from affecting each other and ensures a clean state for each test.

3. **Global Setup and Cleanup**: Use `beforeAll` and `afterAll` to perform setup and cleanup tasks that apply to the entire test suite. This can include initializing connections to external services, setting up mock servers, or cleaning up temporary files.

4. **Configuring Test Environment**: You can also use hooks to configure the test environment, such as setting up test-specific configurations or mocking global objects.

### Example:

```javascript
// Example using Mocha syntax
describe('Example Test Suite', function() {
  before(function() {
    // Runs once before all tests in the suite
    // Set up global resources or perform global setup tasks
  });

  after(function() {
    // Runs once after all tests in the suite
    // Clean up global resources or perform global cleanup tasks
  });

  beforeEach(function() {
    // Runs before each test in the suite
    // Set up test fixtures or perform setup tasks specific to each test
  });

  afterEach(function() {
    // Runs after each test in the suite
    // Clean up resources or perform teardown tasks specific to each test
  });

  // Tests go here...
});
```

Hooks provide a way to manage the lifecycle of your tests and ensure that setup and teardown tasks are performed consistently. They help in writing clean, maintainable test code by reducing duplication and ensuring that tests run in a predictable environment.

# ☝️ Unit testing with async functions

Unit testing with async functions involves testing functions that return promises or use asynchronous operations like callbacks. There are a few key considerations and techniques to keep in mind when unit testing async functions:

### 1. Using `async/await`:

When testing async functions, prefer using `async/await` syntax for cleaner and more readable code. This allows you to write asynchronous tests in a synchronous style, making the test code easier to understand.

### 2. Handling Promises:

Ensure that your test framework supports handling promises. Most modern testing frameworks like Mocha, Jest, and Ava have built-in support for testing async functions. They either support returning a promise from the test function or allow using `async/await` directly within the test function.

### 3. Test Completion:

Make sure your test assertions are completed before the test ends. This can be achieved by either returning the promise from the test function or using `await` to wait for the assertion to complete.

### 4. Mocking and Stubbing:

Use mocking and stubbing libraries like Sinon.js to mock asynchronous dependencies and stub async functions. This allows you to control the behavior of async dependencies during testing and isolate the code under test.

### Example using Mocha and Chai with `async/await`:

Suppose we have an async function `fetchData` that fetches data from an API:

```javascript
// fetchData.js
const axios = require('axios');

async function fetchData() {
  try {
    const response = await axios.get('https://api.example.com/data');
    return response.data;
  } catch (error) {
    throw new Error('Failed to fetch data');
  }
}

module.exports = fetchData;
```

We can write a unit test for this async function using Mocha and Chai:

```javascript
// test/fetchData.test.js
const chai = require('chai');
const chaiAsPromised = require('chai-as-promised');
const sinon = require('sinon');
const axios = require('axios');
const fetchData = require('../fetchData');

// Enable chai-as-promised plugin
chai.use(chaiAsPromised);
const expect = chai.expect;

describe('fetchData', function() {
  it('should fetch data from the API', async function() {
    // Stub the axios.get function to return a resolved promise with mock data
    const axiosStub = sinon.stub(axios, 'get').resolves({ data: 'Mock Data' });

    // Call the async function under test
    const promise = fetchData();

    // Assert that the promise resolves with the expected data
    await expect(promise).to.eventually.equal('Mock Data');

    // Restore the original behavior of axios.get
    axiosStub.restore();
  });

  it('should handle errors when fetching data', async function() {
    // Stub the axios.get function to return a rejected promise
    const axiosStub = sinon.stub(axios, 'get').rejects(new Error('Network Error'));

    // Call the async function under test
    const promise = fetchData();

    // Assert that the promise rejects with the expected error
    await expect(promise).to.be.rejectedWith('Failed to fetch data');

    // Restore the original behavior of axios.get
    axiosStub.restore();
  });
});
```

In this example:
- We use Sinon.js to stub the `axios.get` function and control its behavior during testing.
- We use `chai-as-promised` plugin to enable assertions on promises using `expect(...).to.eventually...`.
- We use `async/await` syntax to handle async operations and wait for promises to resolve or reject.
- We write tests to verify that the async function behaves correctly under different conditions, including successful data retrieval and error handling.

# ✍️ How to write integration tests with a small node server

Writing integration tests for a small Node.js server involves testing the interaction between different parts of your server, including routes, controllers, and database operations. Here's a step-by-step guide on how to write integration tests for a small Node.js server using a testing framework like Mocha along with libraries like Supertest and a database library (e.g., SQLite for simplicity):

### Step 1: Set Up Your Server

First, set up a small Node.js server with routes and controllers. Here's a simple example using Express:

```javascript
// server.js
const express = require('express');
const bodyParser = require('body-parser');
const app = express();

// Middleware
app.use(bodyParser.json());

// Routes
app.get('/api/users', (req, res) => {
  // Controller logic to fetch users from the database
});

app.post('/api/users', (req, res) => {
  // Controller logic to create a new user in the database
});

const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`Server is running on port ${port}`));
```

### Step 2: Write Integration Tests

Use a testing framework like Mocha along with Supertest to write integration tests for your server. Supertest allows you to make HTTP requests to your server and assert the responses.

```javascript
// test/server.test.js
const request = require('supertest');
const app = require('../server');

describe('Integration Tests', function() {
  it('should get list of users', function(done) {
    request(app)
      .get('/api/users')
      .expect(200)
      .end(function(err, res) {
        if (err) return done(err);
        // Add assertions for response body or headers
        done();
      });
  });

  it('should create a new user', function(done) {
    request(app)
      .post('/api/users')
      .send({ name: 'John Doe', email: 'john@example.com' })
      .expect(201)
      .end(function(err, res) {
        if (err) return done(err);
        // Add assertions for response body or headers
        done();
      });
  });
});
```

### Step 3: Set Up Test Database

If your server interacts with a database, set up a test database for integration tests. For simplicity, you can use an in-memory database like SQLite.

```javascript
// db.js
const sqlite3 = require('sqlite3').verbose();
const db = new sqlite3.Database(':memory:');

// Create database schema and seed data
db.serialize(() => {
  db.run('CREATE TABLE users (id INTEGER PRIMARY KEY, name TEXT, email TEXT)');
  db.run('INSERT INTO users (name, email) VALUES (?, ?)', ['John Doe', 'john@example.com']);
});

module.exports = db;
```

### Step 4: Update Server to Use Test Database in Tests

Modify your server to use the test database during integration tests.

```javascript
// server.js
const express = require('express');
const bodyParser = require('body-parser');
const db = require('./db'); // Import test database
const app = express();

// Middleware
app.use(bodyParser.json());

// Routes
app.get('/api/users', (req, res) => {
  db.all('SELECT * FROM users', (err, rows) => {
    if (err) {
      return res.status(500).json({ error: err.message });
    }
    res.json(rows);
  });
});

app.post('/api/users', (req, res) => {
  const { name, email } = req.body;
  db.run('INSERT INTO users (name, email) VALUES (?, ?)', [name, email], function(err) {
    if (err) {
      return res.status(500).json({ error: err.message });
    }
    res.status(201).json({ id: this.lastID });
  });
});

const port = process.env.PORT || 3000;
if (process.env.NODE_ENV !== 'test') {
  app.listen(port, () => console.log(`Server is running on port ${port}`));
}

module.exports = app; // Export app for testing
```

### Step 5: Running Tests

Finally, run your integration tests using the testing framework of your choice (e.g., Mocha):

```bash
npm test
```

This will execute your integration tests, making requests to your server and asserting the responses. Ensure that your server is not running during the tests to prevent conflicts with the test server.

##  🙇 Author

[Vladimir Davidov](https://github.com/v-dav) - Holberton School
