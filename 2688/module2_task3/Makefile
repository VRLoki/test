.PHONY: build run stop clean test help

lint: ## Run static analysis on the source code using golangci-lint
	@golangci-lint run

build: lint ## Compile the source code of the application
	@go build -o awesome-api

run: ## Run the application in the background and write logs to awesome-api.log
	@./awesome-api >./awesome-api.log 2>&1 &

stop: ## Stop the running application
	@pkill awesome-api

clean: ## Stop the application and delete the binary, log, and coverage files
	$(MAKE) stop || true
	rm -rf awesome-api awesome-api.log coverage-units.out coverage-integrations.out

test: unit-tests integration-tests ## Test the application by running unit and integration tests

help: ## Displays the list of targets and their use
	@grep -E -i ^[a-z] Makefile | sed 's/ lint//' | sed 's/ unit-tests integration-tests//' | tr -d '##' | sort

unit-tests: ## Run Golang unit tests with code coverage
	@go test -v -short -coverprofile=coverage-units.out
	@go tool cover -func=coverage-units.out

integration-tests: ## Run Golang integration tests with code coverage
	go test -v -coverprofile=coverage-integrations.out
