CREATE TABLE maker_program(
  id int primary key,
  program_name int NOT NULL,
  program_type varchar(10) DEFAULT NULL,
  program_link text DEFAULT NULL,
  tech_stack_id int foreign key references tech_stack(id),
  tech_type_id int foreign key references tech_stack(id),
  is_program_approved int,
  description varchar(500) DEFAULT NULL,
  status int DEFAULT 1,
  creator_stamp datetime DEFAULT NULL,
  creator_user int DEFAULT NULL,
  );

