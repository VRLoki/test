HUGO=hugo
CLEAN=rm -rf
.PHONY: help

build:	## Generate the website from the markdown and configuration files in the directory dist/
	$(HUGO)

post:	## Create a new blog post whose filename and title come from the environment variables POST_TITLE and POST_NAME
	$(HUGO) new posts/$(POST_NAME).md
	sed -i '2s/.*/title: "$(POST_TITLE)"/' content/posts/$(POST_NAME).md

clean:	## Cleanup the content of the directory dist/
	$(CLEAN) ./dist/

help:	## Show this help usage
	@sed -ne '/@sed/!s/## //p' $(MAKEFILE_LIST)
