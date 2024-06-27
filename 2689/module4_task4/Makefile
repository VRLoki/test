HUGO=hugo
RM=rm -rf
SHELLCHECK=shellcheck
YAMLLINT=yamllint
YQ=yq
MARKDOWN=markdownlint
IMAGE_TAG=$(shell git tag | tail -n 1)
ifeq ($(strip $(IMAGE_TAG)),)
IMAGE_TAG=$(shell git rev-parse --abbrev-ref HEAD)
endif

docker-tests:## Build the Docker image
	container-structure-test test --image awesome:${IMAGE_TAG} --config cst.yml

go-build:	## Builds the API binary file using go
	go build

hugo-build:		## Builds a website using gohugo on the dist folder
	hugo

build: 	## Builds all that is needed for website
	-make go-build
	make hugo-build

post: ## Creates a new post with the title changed to the ENV value.
	$(HUGO) new posts/$(POST_NAME).md
	$(YQ) eval '.title = "$(POST_TITLE)"' ./content/posts/$(POST_NAME).md

clean: ## Remove all files from target folder
	$(RM) dist/*

lint: ## Lints the shell file and run yamllint on success.
	hadolint .Dockerfile
	yamllint -c .yamllint.yml -f parsable **/*.yml

yamllint: ## Yamllint github workflow.
	$(YAMLLINT) ./github-workflow.yml --no-warnings >/dev/null 2>&1 && echo OK
	$(YAMLLINT) ./release_drafter.yml --no-warnings >/dev/null 2>&1 && echo OK
	$(YQ) eval '.jobs.*.steps.[].name' ./github-workflow.yml | wc -l
	$(YQ) eval '.jobs.*.steps.[].run' ./github-workflow.yml | grep -q 'make lint' && echo OK
	$(YQ) eval '.jobs.*.steps.[].run' ./github-workflow.yml | grep -q 'make integration-test'

markdownlint:## Build the Docker image
	$(MARKDOWN) README.md
	$(MARKDOWN) DEPLOY.md

test:	## Tests API using go test
	-make build
	make unit-tests
	make integration-tests

unit-tests: ## Runs different makefile recipes
	go test -v -short -coverprofile=coverage-units.out
	
integration-tests:	## Runs integration test using go test
	go test -v -coverprofile=coverage-integrations.out

validate: ## Tests ensure it is in correct dir
	pwd

package: ## Creates a zip archive of the dist dir api binary.
	docker build -t awesome:${IMAGE_TAG} .
	docker save -o awesome_image.tar awesome:${IMAGE_TAG}
	zip awesome-website.zip awesome-api dist/ awesome_image.tar

.SILENT:
help: ## Target check
	cat Makefile | grep '##' | tr -d '##' | head -n -1