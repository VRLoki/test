#!/bin/bash

sudo apt-get update && sudo apt-get install -y make git zip

# download/install minimal version to use template ananke
sudo curl -L https://github.com/gohugoio/hugo/releases/download/v0.84.0/hugo_extended_0.84.0_Linux-64bit.deb -o hugo.deb
sudo apt install ./hugo.deb
#remove file after installation
sudo rm hugo.deb

# download/install linter

sudo npm install -g markdownlint-cli
sudo npm install -g markdown-link-check
sudo curl -L https://github.com/hadolint/hadolint/releases/download/v2.6.0/hadolint-Linux-x86_64 -o hadolint
sudo chmod u+x hadolint

# Uninstall go
sudo apt-get remove golang-go
rm -rf /usr/local/go

# remove dist directory
rm -rf dist/ 2> /dev/null