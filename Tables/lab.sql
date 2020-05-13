CREATE TABLE lab(
  id int primary key,
  name varchar(50) DEFAULT NULL,
  location varchar(50) DEFAULT NULL,
  address  varchar(255) DEFAULT NULL,
  status int DEFAULT 1,
  creator_stamp datetime DEFAULT NULL,
  creator_user int default);
