#!/bin/bash

# Update package lists and installation of required packages
apt-get update && apt-get install -y hugo make npm curl

# download minimal version to use hugo with the template ananke
sudo curl -L https://github.com/gohugoio/hugo/releases/download/v0.84.0/hugo_extended_0.84.0_Linux-64bit.deb -o hugo.deb

# install hugo
sudo apt install ./hugo.deb

# remove file after the installation
rm hugo.deb

# Install markdownlint-cli and markdown-link-check
sudo npm install -g markdownlint-cli
sudo npm install -g markdown-link-check
