build: ## Generate both the static website with ./dist/ and the API application
	docker run --volume ${GITHUB_WORKSPACE}/module4_task1/:/go golang:1.15.8-buster ls && go build
	hugo > /dev/null 2>&1

build-docker: ## Build and use the Docker image
	docker build -t awesome:build ./.build

run: ## Run the Go application in background, and write logs into a file named awesome-api.log
	./awesome-api >./awesome-api.log 2>&1 &

stop: ## Stop the Go application
	pkill awesome-api

lint: ## Should execute all of the lint steps using the Docker image
	docker run --rm -v "$(PWD)":/usr/src/myapp -w /usr/src/myapp awesome:build markdownlint DEPLOY.md README.md || true

test: ## should execute all of the testing targets (unit-tests, integration-tests and validate
	@make unit-tests 
	@make integration-tests
	@make validate

unit-tests: ## Should be implemented and should execute (successfully) the Golang unit tests
	docker run --volume ${GITHUB_WORKSPACE}/module4_task1/:/go golang:1.15.8-buster ls && go test -v -short -coverprofile=coverage-units.out

integration-tests: ## Should be implemented and should execute (successfully) the Golang integration tests
	docker run --volume ${GITHUB_WORKSPACE}/module4_task1/:/go golang:1.15.8-buster ls && go test -v -coverprofile=coverage-integrations.out

clean: ## should delete all the generated files (logs, test reports, distribution directory, etc.) and call the make stop target as preliminary
	make stop || true
	pkill awesome-api || true
	rm -rf awesome-api awesome-api.log coverage-units.out coverage-integrations.out
	rm -rf dist/*

post: ## Create a new blog post
	hugo new posts/$(POST_NAME).md
	sed -i 's/title: .*/title: "$(POST_TITLE)"/' content/posts/$(POST_NAME).md

validate: ## checks if  the generated HTML is compliant with the W3C (acceptance testing)
	@./w3c_validator.py ./dist/index.html || true

help: ## Prints out the list of targets and their usage.
	@grep -E -i ^[a-z] Makefile | sed 's/ check//' | tr -d '##'

package: ## produces a file awesome-website.zip
	make build
	zip -r awesome-website.zip awesome-api dist/
