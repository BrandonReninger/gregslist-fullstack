-- CREATE TABLE cars(
--  id INT NOT NULL AUTO_INCREMENT,
--  make VARCHAR(255) NOT NULL,
--  model VARCHAR(255) NOT NULL,
--  imgUrl VARCHAR(255) NOT NULL,
--  body VARCHAR(255) NOT NULL,
--  price INT NOT NULL,
--  productionYear INT NOT NULL,
--  userId VARCHAR(255) NOT NULL,
--  PRIMARY KEY (id)
-- )
-- DROP TABLE cars

-- Alter table cars ADD Column productionYear INT NOT NULL


-- 
-- CREATE TABLE jobs(
--     id INT NOT NULL AUTO_INCREMENT,
--     userId VARCHAR(255) NOT NULL,
--     title VARCHAR(100) NOT NULL,
--     salary INT NOT NULL,
--     hoursweek INT NOT NULL,
--     citystate VARCHAR(100) NOT NULL,
--     body VARCHAR(255) NOT NULL,
--     PRIMARY KEY(id)
-- )

INSERT INTO jobs
(title, salary, hoursweek, citystate, body)
VALUES
("garbage man", 40000, 40, "Boise, Idaho", "Just collect the trash")