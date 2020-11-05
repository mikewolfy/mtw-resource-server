dotnet publish -c Release

docker build -t resource-server -f dockerfile .

docker run -p 8080:80 -it --rm --name resources resource-server 