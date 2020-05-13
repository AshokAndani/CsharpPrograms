CREATE TABLE company(
  id int primary key,
  name int NOT NULL,
  address varchar(150) DEFAULT NULL,
  location varchar(50) DEFAULT NULL,
  status int DEFAULT 1,
  creator_stamp datetime DEFAULT NULL,
  creator_user int DEFAULT);
