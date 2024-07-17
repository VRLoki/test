# NodeJS Basics

![Ubuntu Version](https://img.shields.io/badge/Ubuntu-18.04%20LTS-green.svg)
![Node Version](https://img.shields.io/badge/NodeJS-12.x.x-blue.svg)
![Express](https://img.shields.io/badge/Express-Web_Framework-red.svg)
![Mocha](https://img.shields.io/badge/Mocha-Testing_Framework-brightgreen.svg)
![Nodemon](https://img.shields.io/badge/Nodemon-Development_Tool-orange.svg)

![image](https://github.com/v-dav/holbertonschool-web_back_end/assets/115344057/fd09feaa-eea5-4dfa-8f03-6c54ea45b3f3)


## 🧐 Project Overview

Welcome to the NodeJS Basics project! This project is designed to help you build a strong foundation in Node.js, one of the most popular and powerful JavaScript runtime environments. Node.js allows you to run JavaScript on the server side, opening up a world of possibilities for building web applications, APIs, and more.

In this project, you will explore the basics of Node.js, including how to run JavaScript code using Node, work with Node modules, read files, and access command line arguments and the environment using the Process API. You will also learn how to create a small HTTP server using pure Node.js and take it a step further by using the Express.js web framework to create advanced routes and applications.

Additionally, you'll discover how to leverage modern JavaScript features like ES6 with Babel-node and enhance your development workflow with Nodemon.

By the end of this project, you will have a solid understanding of Node.js fundamentals and be ready to tackle more complex Node.js projects.

## 📖 Learning Objectives

By the end of this project, you will be able to explain the following concepts without the need for external references:

- How to run JavaScript using Node.js
- How to use Node.js modules
- How to read files with Node.js
- How to access command line arguments and the environment using the Process API
- How to create a small HTTP server using Node.js
- How to create a small HTTP server using Express.js
- How to create advanced routes with Express.js
- How to use ES6 with Node.js using Babel-node
- How to use Nodemon for faster development

## ⚙️ Ressources

**Read or watch**:

- [Node JS getting started](https://nodejs.org/en/docs/guides/getting-started-guide)
- [Process API doc](https://node.readthedocs.io/en/latest/api/process/)
- [Child process](https://nodejs.org/api/child_process.html)
- [Express getting started](https://expressjs.com/en/starter/installing.html)
- [Mocha documentation](https://mochajs.org/)
- [Nodemon documentation](https://github.com/remy/nodemon#nodemon)


## ⚙️ Setup

### Install NodeJS 12.11.x
(in your home directory):
```
curl -sL https://deb.nodesource.com/setup_12.x -o nodesource_setup.sh
sudo bash nodesource_setup.sh
sudo apt install nodejs -y

$ nodejs -v
v12.11.1

$ npm -v
6.11.3
```


### Install Jest, Babel, and ESLint
in your project directory:

- Install Jest using: npm install --save-dev jest
- Install Babel using: npm install --save-dev babel-jest @babel/core @babel/preset-env @babel/cli
- Install ESLint using: npm install --save-dev eslint

### Files

- `package.json`
```{
  "scripts": {
    "lint": "./node_modules/.bin/eslint",
    "check-lint": "lint [0-9]*.js",
    "dev": "npx babel-node",
    "test": "jest",
    "full-test": "./node_modules/.bin/eslint [0-9]*.js && jest"
  },
  "devDependencies": {
    "@babel/core": "^7.6.0",
    "@babel/node": "^7.8.0",
    "@babel/preset-env": "^7.6.0",
    "eslint": "^6.4.0",
    "eslint-config-airbnb-base": "^14.0.0",
    "eslint-plugin-import": "^2.18.2",
    "eslint-plugin-jest": "^22.17.0",
    "jest": "^24.9.0"
  }
}
```
- `babel.config.js`
```
module.exports = {
  presets: [
    [
      '@babel/preset-env',
      {
        targets: {
          node: 'current',
        },
      },
    ],
  ],
};
```
- `utils.js` (Use when you get to tasks requiring uploadPhoto and createUser.)
```
export function uploadPhoto() {
  return Promise.resolve({
    status: 200,
    body: 'photo-profile-1',
  });
}


export function createUser() {
  return Promise.resolve({
    firstName: 'Guillaume',
    lastName: 'Salva',
  });
}
```
- `.eslintrc.js`
```
module.exports = {
  env: {
    browser: false,
    es6: true,
    jest: true,
  },
  extends: [
    'airbnb-base',
    'plugin:jest/all',
  ],
  globals: {
    Atomics: 'readonly',
    SharedArrayBuffer: 'readonly',
  },
  parserOptions: {
    ecmaVersion: 2018,
    sourceType: 'module',
  },
  plugins: ['jest'],
  rules: {
    'no-console': 'off',
    'no-shadow': 'off',
    'no-restricted-syntax': [
      'error',
      'LabeledStatement',
      'WithStatement',
    ],
  },
  overrides:[
    {
      files: ['*.js'],
      excludedFiles: 'babel.config.js',
    }
  ]
};
```
- `database.csv`
```
firstname,lastname,age,field
Johann,Kerbrou,30,CS
Guillaume,Salou,30,SWE
Arielle,Salou,20,CS
Jonathan,Benou,30,CS
Emmanuel,Turlou,40,CS
Guillaume,Plessous,35,CS
Joseph,Crisou,34,SWE
Paul,Schneider,60,SWE
Tommy,Schoul,32,SWE
Katie,Shirou,21,CS
```

Don’t forget to run `$ npm install` when you have the `package.json`.

## 🙇 Author

- [Vladimir Davidov](https://github.com/v-dav)

---

# Personal Notes about NodeJS, ExpressJS and Next.JS
![image](https://github.com/v-dav/holbertonschool-web_back_end/assets/115344057/ff772fe7-0b38-4372-96d4-22af2b779943)

## Definition
Node.js, Express.js, and Next.js are all JavaScript-based technologies, but they serve different purposes and are used in different contexts.

1. **Node.js:**
    - **Definition:** Node.js is a runtime environment that allows you to execute JavaScript code on the server side. It is built on the V8 JavaScript runtime and provides a set of APIs for building scalable and high-performance network applications.
    - **Key Features:**
        - Asynchronous and event-driven: Node.js is designed to handle asynchronous I/O operations, making it suitable for building scalable and real-time applications.
        - Single-threaded, non-blocking: It uses a single-threaded event loop to handle multiple concurrent connections without the need for multi-threading.
        - Cross-platform: Node.js is compatible with various operating systems, allowing developers to use JavaScript to build server-side applications.
2. **Express.js:**
    - **Definition:** Express.js is a web application framework for Node.js. It simplifies the process of building web applications and APIs by providing a set of robust features and middleware. Express.js is not a separate technology but rather a framework that runs on top of Node.js.
    - **Key Features:**
        - Routing: Allows you to define routes for handling HTTP requests and responses.
        - Middleware: Offers a range of middleware modules to handle various tasks such as authentication, logging, and error handling.
        - Template engines: Supports the use of template engines like EJS or Handlebars for rendering dynamic content.
3. **Next.js:**
    - **Definition:** Next.js is a React-based framework used for building modern web applications. While React is primarily focused on the client side, Next.js extends its capabilities to support server-side rendering (SSR) and static site generation (SSG).
    - **Key Features:**
        - Server-side rendering: Provides the ability to render React components on the server side before sending them to the client, improving performance and SEO.
        - Static site generation: Allows you to pre-render pages at build time, resulting in static HTML files that can be served quickly.
        - Automatic code splitting: Next.js automatically splits your JavaScript code into smaller chunks to optimize loading times.

In summary, Node.js is the runtime environment, Express.js is a web application framework built on top of Node.js, and Next.js is a React-based framework that extends React's capabilities to support server-side rendering and static site generation. They can be used together in a stack to build scalable and performant web applications.

## How create basic simple HTTP server

To create a basic HTTP server using Node.js, you can use the built-in `http` module. Here's a step-by-step guide to creating a simple HTTP server:

1. **Import the `http` module:**
Begin by importing the `http` module using the `require()` function. This module is built into Node.js and provides the functionality needed to create an HTTP server.
    
    ```jsx
    const http = require('http');
    
    ```
    
2. **Create the server:**
Use the `http.createServer()` method to create an HTTP server. This method takes a callback function that will be called for each incoming HTTP request. The callback function receives two arguments: a request object (`req`) and a response object (`res`) that you can use to handle the request and send a response.
    
    ```jsx
    const server = http.createServer((req, res) => {
      // Your code to handle the request and send a response goes here
    });
    
    ```
    
3. **Define how the server responds to requests:**
Inside the callback function, you can define how your server responds to incoming HTTP requests. For example, you can set response headers, send a response body, or handle different HTTP methods (GET, POST, etc.).
    
    Here's a simple example that responds with "Hello, World!" for all incoming requests:
    
    ```jsx
    const server = http.createServer((req, res) => {
      // Set the response header
      res.writeHead(200, { 'Content-Type': 'text/plain' });
    
      // Send the response body
      res.end('Hello, World!\\n');
    });
    
    ```
    
4. **Start the server:**
To start the server and make it listen for incoming requests, use the `listen()` method. Specify the port number on which the server should listen and an optional callback function that is executed when the server starts.
    
    ```jsx
    const port = 3000;
    server.listen(port, () => {
      console.log(`Server is listening on port ${port}`);
    });
    
    ```
    
5. **Run your Node.js script:**
Save your script to a file, for example, `server.js`, and then run it using Node.js from your terminal or command prompt:
    
    ```bash
    node server.js
    
    ```
    
    Your server will start and listen on the specified port (in this case, port 3000).
    

That's it! You've created a basic HTTP server using Node.js. You can access it in your web browser or make HTTP requests to it using tools like `curl` or Postman.
