CREATE TABLE user_details (
  id int NOT NULL,
  email varchar(50) NOT NULL unique,
  first_name varchar(100) NOT NULL,
  last_name varchar(100) NOT NULL,
  password varchar(15) NOT NULL,
  contact_number bigint NOT NULL,
  verified bit DEFAULT NULL,
  PRIMARY KEY (id));
