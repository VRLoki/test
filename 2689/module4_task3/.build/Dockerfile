# parent image
FROM golang:1.15.8-alpine

# Env
ENV PATH="/usr/local/go/bin:${PATH}"

# ash = default for alpine
SHELL ["/bin/sh", "-o", "pipefail", "-c"]

# To install any applications and packages required for your container.
RUN apk update && \
rm -rf /var/lib/apt/lists/*

# hadolint ignore=DL3018
RUN apk add --no-cache curl zip bash nodejs npm

SHELL ["/bin/bash", "-o", "pipefail", "-c"]

# Install hadolint
RUN curl -sSfL -o /usr/local/bin/hadolint https://github.com/hadolint/hadolint/releases/download/v2.6.0/hadolint-Linux-x86_64 \
    && chmod a+x /usr/local/bin/hadolint

# Install hugo
# hadolint ignore=DL3018
RUN apk add --no-cache hugo

# Install Golangcilinand markdownlint
ARG GOLANGCI_VERSION: "1.15.0"
RUN curl -sSfL https://raw.githubusercontent.com/golangci/golangci-lint/master/install.sh | sh -s -- -b "$(go env GOPATH)/bin" v1.29.0 \
&& npm install markdownlint-cli@0.26.0 markdown-link-check@3.8.6


# container-structure-test
# hadolint ignore=DL3018
RUN curl -sSfL -o /usr/local/bin/container-structure-test https://storage.googleapis.com/container-structure-test/latest/container-structure-test-linux-amd64 \
    && chmod +x /usr/local/bin/container-structure-test

# Set the working directory in the container
WORKDIR /app

# Copy everything from the current directory to the PWD (Present Working Directory) inside the container
COPY . ..

# Install markdownlint and run the command
RUN npm install -g markdownlint-cli@0.26.0

# Set the command to execute the markdownlint command
CMD ["markdownlint", "-f", "DEPLOY.md"]
