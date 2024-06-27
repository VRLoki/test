# Deployment Instructions

## Contents of the Archive

The archive contains the following:

- `awesome-api`: The binary executable for the Awesome API.
- `dist/`: The directory containing the generated Hugo website files.

## How to Unarchive

To unarchive the ZIP file, run the following command:

```makefile
make package
```

## Starting and Stopping the Application

To start the application:

```makefile
make build
```

To stop the application:

```makefile
make stop
```

## Customizing Log File Location

By default, the application logs are written to `awesome-api.`log in the
current directory.To customize the log directory, you can modify the `run`
target in the Makefile
or provide a command-line argument to specify the log file path.

## Healthcheck

To quickly verify that the application is running, access the
following endpoint:

```bash
http://localhost:8080/healthcheck
```
