use peoplehobbies;

-- CREATE TABLE persons (
--   id int NOT NULL AUTO_INCREMENT, name VARCHAR(255) NOT NULL, 
--   PRIMARY KEY (id) 
-- );

-- CREATE TABLE hobbys (
--   id int NOT NULL AUTO_INCREMENT, name VARCHAR(255) NOT NULL, description VARCHAR(400), 
--   PRIMARY KEY (id)  
-- );

-- CREATE TABLE peoplehobbys (
--   id int NOT NULL AUTO_INCREMENT, personId int NOT NULL, hobbyId int NOT NULL, PRIMARY KEY (id), 
  
--   FOREIGN KEY (personId) REFERENCES persons(id) ON DELETE CASCADE, FOREIGN KEY (hobbyId) REFERENCES hobbys(id) ON DELETE CASCADE
-- );
-- DROP TABLE peoplehobbys;



-- INSERT INTO persons (name) VALUES ("Jim");
-- INSERT INTO persons (name) VALUES ("Tim");
-- INSERT INTO persons (name) VALUES ("Kim");
-- INSERT INTO persons (name) VALUES ("Bob");

-- INSERT INTO hobbys (name) VALUES ("Swimming");
-- INSERT INTO hobbys (name) VALUES ("Video Games");
-- INSERT INTO hobbys (name, description) VALUES ("Painting", "Optional description");
-- INSERT INTO hobbys (name) VALUES ("Running");
-- INSERT INTO hobbys (name) VALUES ("Reading");
-- INSERT INTO hobbys (name, description) VALUES ("Wood Carving", "Optional description");

-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES (1, 2);
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES (1, 5);
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES (2, 3);
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES (2, 6);
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES (3, 1);
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES (3, 4);
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES (4, 4);
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES (4, 2);
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES (1, 6);
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES (3, 3);
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES (2, 5);
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES (4, 2);

-- SELECT * FROM peoplehobbys ph
-- JOIN hobbys h ON h.id = ph.hobbyId
-- WHERE personId = 1;