CREATE TABLE mentor_ideation_map(
  id int NOT NULL,
  mentor_id int foreign key references mentor(id),
  status int DEFAULT 1,
  creator_stamp datetime DEFAULT NULL,
  creator_user int DEFAULT NULL,
);
