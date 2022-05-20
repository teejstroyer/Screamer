-- liquibase formatted sql 

-- changeset bob:1 
CREATE TABLE Example( Id SERIAL PRIMARY KEY, Name varchar(255));

-- changeset bob:2 
ALTER TABLE Example ADD COLUMN Age int;

-- changeset bob:3
INSERT INTO Example (Name, Age) VALUES ('Jim', 10);
INSERT INTO Example (Name, Age) VALUES ('Carl', 30);
