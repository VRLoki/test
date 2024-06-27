.PHONY: help build go-build hugo-build run stop lint test unit-tests integration-tests validate clean post

lint: ## Run static analysis on the Go source code using golangci-lint
	@golangci-lint run

go-build: ## Compile the Go source code of the application
	@go build -o awesome-api

hugo-build: check ## Builds the website with Hugo and generates the files
	hugo -d dist/

build: go-build hugo-build ## Compile both the Go application and Hugo website

run: ## Run the Go application in the background and write logs to awesome-api.log
	@./awesome-api >./awesome-api.log 2>&1 &

stop: ## Stop the running Go application
	@pkill awesome-api

clean: ## Stop the application, delete the binary, log, coverage files, and Hugo website build
	$(MAKE) stop || true
	rm -rf awesome-api awesome-api.log coverage-units.out coverage-integrations.out
	rm -rf dist/

test: unit-tests integration-tests ## Run both unit and integration tests for the Go application

help: ## Displays the list of targets and their use
	@grep -E -i ^[a-z] Makefile | sed 's/ markdown-check markdown-link-check//' | sed 's/ check//' | sed 's/ lint go-build hugo-build//' | sed 's/ unit-tests integration-tests//' | tr -d '##' | sort

unit-tests: ## Run Golang unit tests with code coverage
	@go test -v -short -coverprofile=coverage-units.out
	@go tool cover -func=coverage-units.out

integration-tests: ## Run Golang integration tests with code coverage
	go test -v -coverprofile=coverage-integrations.out

check: markdown-check markdown-link-check ## Check markdown files for dead links and linting issues

markdown-check: ## Check markdown files for linting issues using markdownlint
	markdownlint content/posts

markdown-link-check: ## Check markdown files for dead links using markdown-link-check
	find content/posts -name '*.md' -exec markdown-link-check {} \;

validate: ## Validate the generated HTML using Holberton's W3C Validator
	-python3 w3c_validator.py ./dist/index.html || true

post: ## Creates a new publication file in the content/posts/ with a specified name and title
	hugo new posts/$(POST_NAME).md
	sed -i 's/title: .*/title: "$(POST_TITLE)"/' content/posts/$(POST_NAME).md
