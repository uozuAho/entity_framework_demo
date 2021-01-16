#!/bin/bash
#
# (re)starts the database, creates the schema and inserts data

set -eu

DOCKER_CONTAINER_NAME=ef-demo-db
DB_NAME=ef-demo-db

docker stop $DOCKER_CONTAINER_NAME || true

docker run -d --rm -p 5432:5432 \
    --name $DOCKER_CONTAINER_NAME \
    --env POSTGRES_PASSWORD=postgres \
    --env POSTGRES_USER=postgres \
    --env POSTGRES_DB=$DB_NAME \
    postgres:13.1-alpine

sleep 1

cat schema.sql | docker exec -i $DOCKER_CONTAINER_NAME psql -U postgres $DB_NAME
cat data.sql | docker exec -i $DOCKER_CONTAINER_NAME psql -U postgres $DB_NAME
