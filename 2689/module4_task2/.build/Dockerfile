FROM golang:1.15.8-alpine

# Install GCC and other required tools
# hadolint ignore=DL3018,DL4006,SC2046
RUN apk update && \
    apk add --no-cache --update curl gcc && \
    export GO111MODULE=on && \
    curl -sSfL https://raw.githubusercontent.com/golangci/golangci-lint/master/install.sh | sh -s -- -b $(go env GOPATH)/bin && \
    rm -rf /var/cache/apk/*

COPY . /usr/src/myapp

# Install markdownlint
# hadolint ignore=DL3016
RUN npm install -g markdownlint-cli

# Set the working directory in the container
WORKDIR /usr/src/myapp
