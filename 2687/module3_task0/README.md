# <p align=center>Testing in the Software Development Methodology</p>

<img src="https://www.mindinventory.com/blog/wp-content/uploads/2022/10/golang.gif"
 width="100%">

## Awesome API with Static Website
  
This project integrates the Golang API with the static website built using Hugo. The application serves both the API web service and the static website from a single web service. The /hello endpoint is integrated with the static website allowing users to input their name and receive a personalized greeting. The application serves the static files from the ./dist/ directory.

## Prerequisites

- Golang v1.15.*
- NPM v7+ with NodeJS v14.*
- Python3

## Workflow

We use GitHub Actions for our Continuous Integration (CI) workflow. The workflow, named `module3_task0`, is defined in the file `.github/workflows/module3_task0.yml`.
  
This workflow is triggered each time there is new code pushed on the repository and once per day. It runs on a virtual machine with Ubuntu 22.04.
  
The workflow performs the following steps:
  
1. Clone the repository
2. Execute the command `make help` to validate that the Makefile is present and implements the `help` target.
  
A symbolic link named `github-workflow.yml` at the root of the project points to the workflow file.
  
## Usage

To build and run the application, use the following commands:

```makefile
$ make build
$ make run
```
  
Then, visit http://localhost:9999/posts/welcome/ to test the "Say Hello" feature.
   
To stop the application, run:
  
```makefile
$ make stop
```

To clean up the generated files, run:

```makefile
$ make clean
```

## Lifecycle

The project includes a `Makefile` to automate the life-cycle of the application. The following targets are available:

- `help`: Display a list of available targets and their usage
- `build`: Compile both the Go application and Hugo website
- `run`: Run the application in the background and write logs to awesome-api.log
- `stop`: Stop the running application
- `lint`: Run static analysis on the source code using golangci-lint
- `test`: Test the application by running unit tests, integration tests, and validate
- `unit-tests`: Run the unit tests of the application with code coverage
- `integration-tests`: Run the integration tests of the application with code coverage
- `check`: Check markdown files for dead links and linting issues
- `clean`: Stop the application and delete the binary, log, coverage files, and Hugo website build
- `post`: Create a new publication file in the content/posts/ directory with a specified name and title

### Example

```makefile
$ make help

help: Display a list of available targets and their usage
build: Compile both the Go application and Hugo website
clean: Stop the application and delete the binary, log, coverage files, and Hugo website build
run: Run the application in the background and write logs to awesome-api.log
stop: Stop the running application
test: Test the application by running unit tests, integration tests, and validate
lint: Run static analysis on the source code using golangci-lint
unit-tests: Run the unit tests of the application with code coverage
integration-tests: Run the integration tests of the application with code coverage
check: Check markdown files for dead links and linting issues
post: Create a new publication file in the content/posts/ directory with a specified name and title

```

# Author

- Mathieu Morel
