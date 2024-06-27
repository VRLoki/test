# Module 2: Testing in the Software Development Methodology

## Learning Objectives

This project aims at practicing with automated tests. The goal is to understand
the pros and cons of different testing methods to be able to understand the value
of doing, or not doing, a kind of test.

After this project, you should be able to:

Understand what linting is the extent of its usages (which kind of file can be linted,
and the impact of running it often)
Understand the difference between unit tests and integration tests
Use code coverage as a helper to write tests
Understand that not only “classical” code is to be tested, but also a
lot of the artifacts we can generate
Understand how “component”-based testing for acceptance and end to end
validation is to be used

## Prerequisites

The following elements are required in addition to the previous
module (“Module 1: Introduction to DevOps:
Automate Everything to Focus on What Really Matters”) prerequisites.:

### Concepts

You should have a basic knowledge of the following concepts:

- What a compiled language is (C/C#/Golang/Rust/etc.)

  - Generation process from source to executable binary
  - Basic types: string, integer, boolean, maps, arrays
  - Basic algorithmic: loops, conditional, functions

- Installing command line tools with NPM (in addition to package managers)

- Understand the basics of the HTTP protocol (client/server, verbs, headers)

### Tooling

This project needs the following tools / services:

- An HTML5-compliant web browser (Firefox, Chrome, Opera, Safari, Edge, etc.)
- A free account on [GitHub](https://github.com/), referenced as `GitHub Handle`
- A shell terminal with bash, zsh or ksh, including the standard
Unix toolset (ls, cd, etc.)
- [GNU](https://www.gnu.org/software/make/) Make in version 3.81+
- [Git](https://git-scm.com/book/en/v2/Getting-Started-The-Command-Line)
(command line) in version 2+
- [Go Hugo](https://gohugo.io/) v0.84+
- [Golang](https://intranet.hbtn.io/rltoken/5ypbIenKj6LiymRm619--A) v1.15.*
- [NPM](https://intranet.hbtn.io/rltoken/RcU82lwHHO4xEQCtWEv1sg)v7
- [NodeJS](https://intranet.hbtn.io/rltoken/XWIqoQhjv16uVWfGbCdInw) v14.*
- [markdownlint-cli](https://intranet.hbtn.io/rltoken/hplwMW8M8BKVQyhDso0pOw) v0.26.0
- [markdown-link-check](https://intranet.hbtn.io/rltoken/BRJGBHXvkAUKt50KrFOm0A)
v3.8.6
- [Holberton's W3C Validator](https://intranet.hbtn.io/rltoken/ll8gJ8CPoI9tfn1OTDE8rA)
- [yq](https://intranet.hbtn.io/rltoken/9wlxJjlqCE6XyPa6TQ0RsQ) v4.5.0
- [shellcheck](https://intranet.hbtn.io/rltoken/7e95a2wDfOHFQGKJqRlHgg) v0.*
- [yamllint](https://intranet.hbtn.io/rltoken/B1BZ_C_5ANyq005Vd0LWNw) v1.*
- [jq](https://intranet.hbtn.io/rltoken/pVjsOvuSQavip_1Y4u--4Q) v1.*
- [“Hadolint”, the Haskell Dockerfile Linter](https://intranet.hbtn.io/rltoken/nGlz7o9eZiyOcK8YWq4nxg)
v2.6.0
- [Google’s Container Structure Test](https://intranet.hbtn.io/rltoken/-xKynPTm9JMlE41n8CYtxg)
v1.10.0

How to use the make file:

## Lifecycle

In the DevOps methodology, the development lifecycle is generally staying the same.
Use the following steps :

To execute the Makefile use the following syntax:
 ```make <command>```

 command are availaible :

- `help`:
  - show all command description

- `build`:
  - Builds a new version of the website to folder `/dist/` in docker image

- `build-docker`:
  - Builds docker image

- `docker-tests`:
  - Tests docker image

- `run`: Run the application in background by executing the binary ```awesome-api```,
and write logs into a file named ```awesome-api.log```

- `clean`:
  - Delete binary and log file

- `post`:
  - Creates a new post in the contents/post folder with POST_TITLE and POST_NAME
  set from the ENV variables.

- `check`:
  - Lint of the Markdown source files using command line AND
  analysis of the links with
  command line. If one test fails, the command failed.

- `validate`:
  - validate the file ./dist/index.html by using command line. But non-blocking
  quality indicator

- `test`: Test to ensure that it behaves as expected.

- `lint`: Test lint in the files

- `unit-tests`: Run files with the _test.go suffix

- `integration-tests`: Run Golang integration tests

- `package`: Produce awesome-website.zip containing awesome-api and dist
directory and docker image

- `stop`: Stop the application with the command kill XXXXX where XXXXX is the Process
ID of the application.

## Workflow

- Workflow module3_task 0 :
-> Clone the repository,
-> Use ubuntu-22.04 as the virtual machine.
-> Position yourself in the correct directory and execute the command make help to
validate that the Makefile is present and implements the help target.
-> This workflow must be triggered:
  Each time there is new code pushed on your repository,
  And once per day (whatever time you want).

- Workflow module3_task 1 :
-> Ensure that the workflow is executed into an Ubuntu 22.04
-> install with script setup.sh
-> 1 job with at least 7 steps (checkout, running setup.sh and then the 5 make commands)

- Workflow module3_task 2 :
same as previous
- target package to generate ZIP file
- archive ZIP file if tests and validation have run successfully

- Workflow module3_task 3 :
same as previous
- Generate an archive when triggered by a tag
- Create a release with the archive and content of ```DEPLOY.md```
when triggered by a tag
- Behave the same as “module3_task2” when triggered by something else than a tag
(e.g. archive without version name, and no release)
- Be enabled in GitHub Actions and must have been run successfully with a tag ```1.0.0```

- Workflow module3_task 4 :
New workflow for new collaboration process by using GitHub Pull Request:
->would be triggered by a pull request (additionally to the existing
triggers). It should behave the same in a Pull Request as when triggered
by a code change.

- Workflow release_drafter :
-> Generate a changelog based on the merged Pull Request’s titles,
since the previous release
-> Write this changelog in a “draft GitHub Release”
-> Be linked into the current task’s directory (same pattern as the
github-workflow.yml file)
-> Be configured through the default .github/release_drafter.yml
-> Runs on ubuntu-22.04

- Workflow module3_task5 :
-> A new step “deploy”, based on the “nwtgck/actions-netlify” Action, is run
as the last workflow’s step
-> When the workflow is triggered by a Pull Request, the deploy step is done
on a preview site.
-> When the workflow is triggered on the principal branch, then it is deploy to production

- Workflow module4_task0 :
same as module3_task5

- Workflow module4_task1 :
same as previous

- Workflow module4_task1 :
same as previous
& Docker image: lint and test

- Workflow module4_task2 :
same as previous
& Docker image test

- Workflow module4_task3 :
Packaging the Application as a Docker Image

## Docker Image

Construction of Dockerfile with all environment when build-docker is invoked.
-> name: awesome:build
All instruction existing inside the Docker Image awesome:build.

## Story

Now that your teams are using CI/CD, you would like to solve the “reproducibility”
challenge for both the build environment and the production environment.

While it’s not the only way of doing it, Docker would be a great tool for solving
these challenges.
