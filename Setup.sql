use peoplehobbies;

CREATE TABLE persons (
  id int NOT NULL AUTO_INCREMENT, name VARCHAR(255) NOT NULL, 
  PRIMARY KEY (id) 
);

CREATE TABLE hobbys (
  id int NOT NULL AUTO_INCREMENT, name VARCHAR(255) NOT NULL, description VARCHAR(400), 
  PRIMARY KEY (id)  
);

CREATE TABLE peoplehobbys (
  id int NOT NULL AUTO_INCREMENT, personId int NOT NULL, hobbyId int NOT NULL, PRIMARY KEY (id), 
  
  FOREIGN KEY (personId) REFERENCES hobbys(id) ON DELETE CASCADE, FOREIGN KEY (hobbyId) REFERENCES persons(id) ON DELETE CASCADE
);



INSERT INTO persons (name) VALUES ("Jim");
INSERT INTO persons (name) VALUES ("Tim");
INSERT INTO persons (name) VALUES ("Kim");
INSERT INTO persons (name) VALUES ("Bob");

INSERT INTO hobbys (name) VALUES ("Swimming");
INSERT INTO hobbys (name) VALUES ("Video Games");
INSERT INTO hobbys (name, description) VALUES ("Painting", "Optional description");
INSERT INTO hobbys (name) VALUES ("Running");
INSERT INTO hobbys (name) VALUES ("Reading");
INSERT INTO hobbys (name, description) VALUES ("Wood Carving", "Optional description");

-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES ();
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES ();
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES ();
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES ();
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES ();
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES ();
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES ();
-- INSERT INTO peoplehobbys (personId, hobbyId) VALUES ();