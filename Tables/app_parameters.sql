CREATE TABLE app_parameters (
  id int NOT NULL,
  key_type varchar(20) NOT NULL,
  key_value varchar(20) NOT NULL,
  key_text varchar(80) DEFAULT NULL,
  cur_status char(1) DEFAULT NULL,
  lastupd_user int DEFAULT NULL,
  lastupd_stamp datetime DEFAULT NULL,
  creator_stamp datetime DEFAULT NULL,
  creator_user int DEFAULT NULL,
  seq_num int DEFAULT NULL
  );

