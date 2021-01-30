CREATE TABLE movies (
    id SERIAL PRIMARY KEY,
    title varchar(320) NOT NULL,
    director varchar(320) NOT NULL,
    year int NOT NULL,
    length_minutes int NOT NULL
);

CREATE TABLE box_office (
    id SERIAL PRIMARY KEY,
    movie_id int not null,
    rating float not null,
    domestic_sales bigint not null,
    international_sales bigint not null,
    constraint fk_movie
        foreign key(movie_id)
        references movies(id)
        on delete cascade
);

CREATE TABLE actors (
    id SERIAL PRIMARY KEY,
    name varchar(320) NOT NULL
);

CREATE TABLE movie_actors (
    movie_id int not null,
    actor_id int not null,
    constraint fk_movie
        foreign key(movie_id)
        references movies(id),
    constraint fk_actor
        foreign key(actor_id)
        references actors(id)
);
