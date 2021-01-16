CREATE TABLE movies (
    id SERIAL PRIMARY KEY,
    title varchar(320) NOT NULL,
    director varchar(320) NOT NULL,
    year int NOT NULL,
    length_minutes int NOT NULL
);
