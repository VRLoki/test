# Answer to operations team’s usual questions

## What is in the archive and how to unarchive it?

The archive ```awesome-website.zip``` contains awesome-api binary (api server)
file and the dist/ directory (directory compiled).
To unarchive use the following command :  ```unzip awesome-webstite.zip```

## What are the commands to start and stop the application?

To **RUN** the application : ```make run```
To **STOP** the application : ```make stop```

## How to customize where the application logs are written?

As default logs are written in ```awesome-api.log``` file. If you want
change this localisation use this command : ```make run > [Path/File_name].log 2>&1```

## How to “quickly” verify that the application is running (healthcheck)?

Use the ```curl localhost:9999/health```

## Release

A Github Release is created with the ```tag 1.0.0``` and contain archive
awesome-website.zip + content of the file DEPLOY.md as text for the release.

## Pull Requests

A new collaboration process used GitHub Pull Request :
-> Instead of pushing code to the principal branch, developers
are expected to open pull requests
-> A Pull Request can only be merged if the associated workflow is executed successfully

## Production

Automate process in a new workflow named module3_task5

-> A new step “deploy”
-> When the workflow is triggered by a Pull Request, the deploy step is
done on a preview site.
-> When the workflow is triggered on the principal branch, then it is deploy to production

Now, the communication team should be able to preview their changes on Pull
Requests, and deploy their changes to production as soon as the Pull
Requests are merged.
