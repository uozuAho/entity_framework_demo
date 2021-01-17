# Entity framework demo

This is a practical introduction to Entity Framework (EF).
It roughly follows the tutorials at https://sqlbolt.com/.


# Getting started

- install docker & dotnet 5
- run `cd db_setup && ./start_db.sh`. This script
    - starts a postgres database in a docker container
    - creates the database schema
    - inserts data into the database
- run `dotnet run --project EfDemo.Console/`

Have a look at the EfDemo.Console project, and uncomment the demonstrations you
want to run.


# Further reading

- [how EF works, what is an ORM etc.](https://www.entityframeworktutorial.net/basics/how-entity-framework-works.aspx)
