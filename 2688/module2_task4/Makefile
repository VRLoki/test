.PHONY: build clean post check validate help 

build: check ## Builds the website with Hugo and generates the files
	hugo -d dist/

clean: ## Deletes all files on dist directory
	rm -rf dist/*

post: ## Creates a new publication file in the content/posts/ with a specified name and title
	hugo new posts/$(POST_NAME).md
	sed -i 's/title: .*/title: "$(POST_TITLE)"/' content/posts/$(POST_NAME).md

check: ## Check markdown files for dead links and linting issues
	@markdownlint content/posts
	@find content/posts -name '*.md' -exec markdown-link-check {} \;

validate: ## Validate the generated HTML using Holberton's W3C Validator
	-python3 w3c_validator.py ./dist/index.html || true

help: ## Displays the list of targets and their use
	@grep -E -i ^[a-z] Makefile | sed 's/ check//' | tr -d '##' | sort