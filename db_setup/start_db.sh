#!/bin/bash
#
# (re)starts the database, creates the schema and inserts data

set -eu

DB_NAME=ef-demo-db
DB_CONTAINER_NAME=db
PGADMIN_PORT=15432

docker-compose down
docker-compose up -d

sleep 1

cat schema.sql | docker exec -i $DB_CONTAINER_NAME psql -U postgres $DB_NAME
cat data.sql | docker exec -i $DB_CONTAINER_NAME psql -U postgres $DB_NAME

echo "All done! Connect to pgadmin at http://localhost:$PGADMIN_PORT"
echo
echo "pgadmin credentials:"
echo "username: admin@pgadmin.com"
echo "password: password"
echo
echo "Once connected to pgadmin:"
echo "- click 'Add New Server'"
echo "- enter any name, the click on 'Connection'"
echo "- enter the following details"
echo "  - Host name/address:    db"
echo "  - Port:                 5432"
echo "  - Username:             postgres"
echo "  - Password:             postgres"
echo
echo "Re-run this script at any time to reset the database"
