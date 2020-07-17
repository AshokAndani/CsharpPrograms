CREATE TABLE mentor(
  id int primary key,
  name varchar(50) DEFAULT NULL,
  mentor_type varchar(20) DEFAULT NULL,
  lab_id int NOT NULL,
  status int DEFAULT 1,
  creator_stamp datetime DEFAULT NULL,
  creator_user int DEFAULT NULL,
);
