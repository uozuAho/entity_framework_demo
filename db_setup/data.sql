INSERT INTO movies (title, director, year, length_minutes) VALUES
('Toy Story', 'John Lasseter', 1995, 81),
('A Bug''s Life', 'John Lasseter', 1998, 95),
('Toy Story 2', 'John Lasseter', 1999, 93),
('Monsters, Inc.', 'Pete Docter', 2001, 92),
('Finding Nemo', 'Andrew Stanton', 2003, 107),
('The Incredibles', 'Brad Bird', 2004, 116),
('Cars', 'John Lasseter', 2006, 117),
('Ratatouille', 'Brad Bird', 2007, 115),
('WALL-E', 'Andrew Stanton', 2008, 104),
('Up', 'Pete Docter', 2009, 101),
('Toy Story 3', 'Lee Unkrich', 2010, 103),
('Cars 2', 'John Lasseter', 2011, 120),
('Brave', 'Brenda Chapman', 2012, 102),
('Monsters University', 'Dan Scanlon', 2013, 110);

INSERT INTO box_office (movie_id, rating, domestic_sales, international_sales) VALUES
(5, 8.2, 380843261, 555900000),
(14, 7.4, 268492764, 475066843),
(8, 8, 206445654, 417277164),
(12, 6.4, 191452396, 368400000),
(3, 7.9, 245852179, 239163000),
(6, 8, 261441092, 370001000),
(9, 8.5, 223808164, 297503696),
(11, 8.4, 415004880, 648167031),
(1, 8.3, 191796233, 170162503),
(7, 7.2, 244082982, 217900167),
(10, 8.3, 293004164, 438338580),
(4, 8.1, 289916256, 272900000),
(2, 7.2, 162798565, 200600000),
(13, 7.2, 237283207, 301700000);

INSERT INTO actors (name) VALUES
('Rishi Allegra'),
('Eva Marzena'),
('Maunu Ebbe'),
('Arman Sharmila');

INSERT INTO movie_actors (movie_id, actor_id) VALUES
(1, 1),
(1, 2),
(2, 1),
(2, 3),
(2, 4),
(3, 1),
(5, 1),
(6, 1),
(6, 2),
(6, 3),
(6, 4);
