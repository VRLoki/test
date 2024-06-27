HUGO=hugo
CLEAN=rm -rf

build:
	$(HUGO)

post:
	$(HUGO) new posts/$(POST_NAME).md
	sed -i '2s/.*/title: "$(POST_TITLE)"/' content/posts/$(POST_NAME).md

clean:
	$(CLEAN) ./dist/
