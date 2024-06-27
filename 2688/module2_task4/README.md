# <p align=center>Holbertonschool Validation</p>

<img src="https://www.freecodecamp.org/news/content/images/size/w2000/2021/12/2220.jpg" width="100%">

# Production Deployment
This project contains the source code and configurations necessary to generate a static website using Hugo. The setup.sh script automates the installation of dependencies and generation of the website.

## Prerequisites

- A Ubuntu 18.04 environment
- Docker (optional, for running the script in an isolated environment)

## Project Structure

The project is organized as follows:

```c
├── archetypes/         # Content templates
├── content/            # Website content
├── data/               # Additional data
├── layouts/            # Presentation templates
├── static/             # Static files
├── themes/             # Custom themes
├── config.toml         # Site configuration
└── setup.sh            # Installation script
```

## Usage

1. Clone this repository to your local machine.

```bash
https://github.com/MathieuMorel62/holbertonschool-validation.git
```

2. Navigate to the `module1_task4` project directory.
3. Modify the `config.toml` file to customize the site configuration, add content, etc.
4. Make the `setup.sh` script executable by running the following command: `chmod +x setup.sh`.
5. Run the `setup.sh` script to install dependencies and generate the website: `./setup.sh`.

## Usage with Docker (optional)
You can run the `setup.sh` script in an isolated environment using Docker. To do so, run the following command:

```bash
docker run --rm --tty --interactive --volume=$(pwd):/app --workdir=/app ubuntu:18.04 /bin/bash
```

Once you are inside the Docker environment, follow steps 3 and 4 mentioned above to configure the site, make the script executable, and run it.

## Examples

Here are some examples of how you can customize and configure your generated website:

- Change the site's theme by modifying the `theme = "..."` line in the `config.toml` file.
- Add content by creating a new file in the `content/` directory.
- Add images or other static files by placing them in the `static/` directory.
- Customize the site's presentation template by modifying files in the `layouts/` directory.

## Lifecycle

The following targets are available in the Makefile:
  
- `build`: Builds the website with Hugo and generates the files.
- `clean`: Deletes all files in the dist directory.
- `post`: Creates a new publication file in the content/posts/ directory with a specified name and title.
- `check`: Checks markdown files for dead links and linting issues.
- `validate`: Validates the generated HTML using Holberton's W3C Validator.
- `help`: Displays the list of targets and their use.
  
To execute a target, run `make <target_name>` in the terminal.

## Result

After running the `setup.sh` script, the generated website will be available in the `./dist` directory. You can now deploy this site to a server of your choice.

-------------------

## Author

- Mathieu Morel
