CREATE TABLE candidate_techstack_assignment(
  id int primary key,
  requirement_id int foreign key references company_requirement(id),
  candidate_id bigint foreign key references fellowship_candidates(id),
  assign_date datetime DEFAULT NULL,
  status varchar(20) DEFAULT NULL,
  creator_stamp datetime DEFAULT NULL,
  creator_user int DEFAULT NULL,
);
