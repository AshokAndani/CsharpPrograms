CREATE TABLE candidate_bank_det(
  id int primary key,
  name varchar(100) NOT NULL,
  account_num int NOT NULL,
  is_account_num_verified int DEFAULT 0,
  ifsc_code varchar(20) NOT NULL,
  is_ifsc_code_verified int DEFAULT 0,
  pan_number varchar(10) DEFAULT NULL,
  is_pan_number_verified int DEFAULT 0,
  addhaar_num int NOT NULL,
  is_addhaar_num_verified int DEFAULT 0,
  candidate_id bigint foreign key references fellowship_candidates(id),
  creator_stamp datetime DEFAULT NULL,
  creator_user int DEFAULT NULL
);
