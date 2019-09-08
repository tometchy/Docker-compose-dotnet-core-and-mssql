# Docker compose Dotnet Core and MySQL example system 

Example docker-compose system, based on .NET Core project and MySQL database (accessed with _Dapper_).

Dotnet Dockerfile and basic Docker setup based on [SoftwareDeveloper.Blog introduction to Docker](https://www.softwaredeveloper.blog/multi-project-dotnet-core-solution-in-docker-image).

Docker-compose configuration used in this example is explained line by line in [SoftwareDeveloper.Blog introduction to docker-compose](https://www.softwaredeveloper.blog/docker-compose-introduction-dotnet-core-app-composed-with-mysql-database).

## Docker-compose up
if you want to see this example running, you can just type `docker-compose up` from solution directory.

## Docker-compose up -d
If you want run this example but without attaching console, run _docker-compose up_ in detach mode - `docker-compose up -d`.

## Docker-compose up --build
If you have already composed system up, but then changed source code, you need to pass _--build_ parameter, when running _docker-compose up_ next time: `docker-compose up --build`.
Of course it can be used along with detach parameter.

## Docker-compose down
When you want to clean up containers and networks created by _docker-compose_, just type `docker-compose down` from solution directory.

## Check if system works
If you want to see if this example system works properly, just access in your browser following GET address - `http://localhost:8080` and you should see following results taken from database:

``` json
[
  {
    "id": 1,
    "name": "Dependency Injection Principles, Practices, and Patterns",
    "description": "Book by Steven van Deursen and Mark Seemann"
  },
  {
    "id": 2,
    "name": "Agile Software Development, Principles, Patterns, and Practices",
    "description": "Book by Robert C. Martin"
  }
]
```

If you see empty result, wait a while and try again - maybe MyQSL database is not fully initialized yet.