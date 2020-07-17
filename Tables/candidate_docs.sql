CREATE TABLE candidate_docs(
  id int primary key,
  doc_type varchar(20) DEFAULT NULL,
  doc_path varchar(500) DEFAULT NULL,
  status int DEFAULT 1,
  creator_stamp datetime DEFAULT NULL,
  creator_user int DEFAULT NULL,
  candidate_id bigint foreign key references fellowship_candidates(id)
);
