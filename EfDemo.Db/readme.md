# Entity framework demo database

# Updating the entity framework model

This is a database-first project, ie. the schema is defined first by
../db_setup/schema.sql. To update the entity framework model after changing that
file, you can use the `ef` tool's reverse engineering capability:

```sh
# start the database and initialise its schema
pushd ../db_setup
./start_db

popd
# if you haven't installed the ef tool yet:
dotnet tool install --global dotnet-ef
# reverse engineer entity framework model from the running database
dotnet ef dbcontext scaffold "Server=localhost;Port=5432;Database=ef-demo-db;User Id=postgres;Password=postgres;" Npgsql.EntityFrameworkCore.PostgreSQL --force
```
