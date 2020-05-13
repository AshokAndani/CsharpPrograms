CREATE TABLE mentor_techstack(
  id int primary key,
  mentor_id int foreign key references mentor(id),
  tech_stack_id int foreign key references tech_stack(id),
  status int DEFAULT 1,
  creator_stamp datetime DEFAULT NULL,
  creator_user int DEFAULT NULL,
);
