#!/usr/bin/python3
from css_parser import CSSParser

if __name__ == '__main__':
    parser = CSSParser("output_0.css")
    css = parser.parse()
    
    # Number of keys
    if len(css) != 4:
        print("Too much selectors: {}".format(", ".join(css.keys())))
        exit(0)
    
    for photo_name in ["julien", "john", "sam", "damian"]:
        c_photo_el = css.get(".photo-{}".format(photo_name))
        if c_photo_el is None:
            print("Missing '.photo-{}'".format(photo_name))
            exit(0)
        if len(c_photo_el) != 1:
            print("Too much style for '.photo-{}': {}".format(photo_name, ", ".join(c_photo_el.keys())))
            exit(0)
        if c_photo_el.get('background', "").lower() != "image-url(\"photos/{}.jpg\")no-repeat;".format(photo_name):
            print("Not the right '.photo-{}' 'background': {}".format(photo_name, c_photo_el))
            exit(0)

    print("OK", end="")
