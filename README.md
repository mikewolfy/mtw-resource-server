# mtw-resource-server

## To build and run container

```sh
#Publishes the app
dotnet publish -c Release
```

```sh
# builds a container image named 'resource-server' using the dockerfile in the current folder
docker build -t resource-server -f dockerfile .
```

```sh
# will verify that the image was created
docker images
```

```sh
# creates a container named 'resource-server' based on the 'resource-server' image
docker create --name resource-server-con resource-server
```

```sh
# lists running containers to verify that the container was created
docker ps -a
```

```sh
# starts the new container
docker start resource-server-con
```

```sh
# combines the 'docker create' and 'docker start' commands
# '-it' will connect using the current terminal
# '--rm' will remove the container once the terminal is closed
# '-p' maps the ports
# '--name' sets the name of the container
# '-d' will run container in the background
docker run -p 8080:80 -it --rm --name resources resource-server 
```

```sh
# stops the container
docker stop resource-server-con
```

```sh
# attaches to the container, '--sig-proxy=false' will ensure that Ctrl+C doesn't end the container
docker attach --sig-proxy=false core-counter
```

Access the app here [http://localhost:8080/api/quotes](http://localhost:8080/api/quotes)