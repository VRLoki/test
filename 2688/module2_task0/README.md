# <p align=center>Testing in the Software Development Methodology</p>

<img src="https://user-images.githubusercontent.com/113856302/236673370-58c63d54-f6da-41be-891c-522db6b9addc.png" width="100%">

## Awesome API
  
Awesome API is a simple HTTP web server written in the Golang language. It listens to incoming HTTP requests on localhost:9999.

## Prerequisites

- Golang v1.15.*
- NPM v7+ with NodeJS v14.*
- Python3

## Features

- Responds with `404 Not Found` for the root path (e.g. `http://localhost:9999/`)
- Responds with `ALIVE` for the `/health` path (e.g. `http://localhost:9999/health`)

## Project Setup

1. Create an empty directory and navigate to it:

```bash
mkdir awesome-api
cd awesome-api
```

2. Initialize the Golang project with a custom identifier:

```go
go mod init github.com/<your github handle>/awesome-api
```

3. Create a `main.go` file with the provided Golang source code.

```go
package main

import (
  "fmt"
  "io"
  "log"
  "net/http"
  "os"

  "github.com/gorilla/mux"
)

func main() {
  httpAddr := "0.0.0.0:9999"
  if port := os.Getenv("PORT"); port != "" {
    httpAddr = "0.0.0.0:" + port
  }
  fmt.Println("HTTP Server listening on", httpAddr)

  // Start an HTTP server using the custom router
  log.Fatal(http.ListenAndServe(httpAddr, setupRouter()))
}

func setupRouter() *mux.Router {
  // Create a new empty HTTP Router
  r := mux.NewRouter()

  // When an HTTP GET request is received on the path /health, delegates to the function "HealthCheckHandler()"
  r.HandleFunc("/health", HealthCheckHandler).Methods("GET")

  return r
}

func HealthCheckHandler(w http.ResponseWriter, r *http.Request) {
  // Print a line in the logs
  fmt.Println("HIT: healthcheck")

  // Write the string "ALIVE" into the response's body
  io.WriteString(w, "ALIVE")

  // End of the function: return HTTP 200 by default
}
```

## Lifecycle

The project includes a `Makefile` to automate the life-cycle of the application. The following targets are available:

- `build`: Compile the source code of the application
- `run`: Run the application in the background and write logs to `awesome-api.log`
- `stop`: Stop the running application
- `clean`: Stop the application and delete the binary and log files
- `test`: Test the application by making requests to `/` and `/health`
- `help`: Display a list of available targets and their usage

### Example

```makefile
$ make help

help: Display a list of available targets and their usage
build: Compile the source code of the application
clean: Stop the application and delete the binary and log files
run: Run the application in the background and write logs to awesome-api.log
stop: Stop the running application
test: Test the application by making requests to / and /health
```

# Author

- Mathieu Morel
