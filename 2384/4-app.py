#!/usr/bin/env python3
""" Basic Flask app, Basic Babel setup, Get locale from request,
    Parametrize templates, Force locale with URL parameter """
from flask import Flask, render_template, request
from flask_babel import Babel

app = Flask(__name__)
babel = Babel(app)
"""Babel object"""


class Config(object):
    """class"""
    LANGUAGES = ['en', 'fr']
    BABEL_DEFAULT_LOCALE = 'en'
    BABEL_DEFAULT_TIMEZONE = 'UTC'


app.config.from_object(Config)
"""class config"""


@app.route('/')
def root():
    """app.py"""
    return render_template("4-index.html")


def get_locale():
    """ to determine the best match with our supported languages """
    localLang = request.args.get('locale')
    supportLang = app.config['LANGUAGES']
    if localLang in supportLang:
        return localLang
    else:
        return request.accept_languages.best_match(app.config['LANGUAGES'])

babel.init_app(app, locale_selector=get_locale)

if __name__ == "__main__":
    app.run()
