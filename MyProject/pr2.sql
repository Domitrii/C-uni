CREATE DATABASE library;
USE library;
CREATE TABLE anime (
    id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(50)
);


ALTER TABLE anime ADD COLUMN year INT;

INSERT INTO anime (title, year) VALUES 
('One piece', 1998),
('Naruto', 2002),
('HxH', 1998),
('Demon Slayer: Kimetsu no Yaiba', 2019),
('Seven Deadly Sins', 2014);

SELECT * FROM anime;

CREATE PROCEDURE get_odd_year_anime()
SELECT * FROM anime WHERE year % 2 != 0;

CALL get_odd_year_anime();