alter database Dummy
add Filegroup Weight_50
Go 

alter database Dummy
add Filegroup Weight_60
Go 

alter database Dummy
add Filegroup Weight_70
Go 

alter database Dummy
add File
(
  Name=PartWeights_50,
  FileName='C:\Users\Lenovo\Desktop\TestFile\PartWeights_50ndf',
  Size=1024 KB,
  Maxsize=unlimited,
  Filegrowth=200 kb
)
To FileGroup Weight_50
Go

alter database Dummy
add File
(
  Name=PartWeights_60,
  FileName='C:\Users\Lenovo\Desktop\testFile\PartWeights_60.ndf',
  Size=1024 KB,
  Maxsize=unlimited,
  Filegrowth=200 kb
)
To FileGroup Weight_60
Go

alter database Dummy
add File
(
  Name=PartWeights_70,
  FileName='C:\Users\Lenovo\Desktop\testfile\PartWeights_70.ndf',
  Size=1024 KB,
  Maxsize=unlimited,
  Filegrowth=200 kb
)
To FileGroup Weight_70
Go


create partition function pt_Weightwise_fun(int)
as range left for values (50,60)

create partition scheme pt_Weightwise_Sch
As
Partition pt_Weightwise_fun
To
(Weight_50,Weight_60,Weight_70);

create table Pt_Employees
(
Id int ,
Name varchar(max),
weight int
) On pt_Weightwise_Sch (weight);


select * from Pt_Employees;
select * from sys.filegroups

insert into Pt_Employees(Id,Name,weight)(select * from Employee);

select $Partition.pt_Weightwise_fun(weight)as partionNumber ,*
from Pt_Employees

SELECT part.partition_number AS [Partition Number],
		fle.name AS [Partition Name],
		part.rows AS [Number of Rows]
FROM sys.partitions AS part
JOIN SYS.destination_data_spaces AS dest ON
part.partition_number = dest.destination_id
JOIN sys.filegroups AS fle ON
dest.data_space_id = fle.data_space_id
WHERE OBJECT_NAME(OBJECT_ID) = 'Pt_Employees 

-- to create the function
create partition function partitionbydate(datetime)
as range right for values('20190201','20190301','20190401',
               '20190501', '20190601', '20190701', '20190801', 
               '20190901', '20191001', '20191101', '20191201');

-- to create the Scheme
create partition scheme partitionbydatescheme
as partition partitionbydate
to (Janaury, february, march, aprilll, may, june , july , august, september,october, november, december)

--to create the partition table
CREATE TABLE DatewisePartitionUser_engagement_MIS(
id int NOT NULL,
candidate_id int NOT NULL,
Date_Time  DATETIME NOT NULL,
Cpu_Count int NOT NULL,
Cpu_Working_Time Decimal(11,3) NOT NULL,
Cpu_idle_Time Decimal(11,3) NOT NULL,
cpu_percent Decimal(11,3) NOT NULL,
Usage_cpu_count int NOT NULL,
number_of_software_interrupts_since_boot Decimal(11,3) NOT NULL,
number_of_system_calls_since_boot int NOT NULL,
number_of_interrupts_since_boot int NOT NULL,
cpu_avg_load_over_1_min Decimal(11,3) NOT NULL,
cpu_avg_load_over_5_min   Decimal(11,3) NOT NULL,
cpu_avg_load_over_15_min Decimal(11,3) NOT NULL,
system_total_memory BIGINT NOT NULL,
system_used_memory BIGINT NOT NULL,
system_free_memory BIGINT NOT NULL,
system_active_memory BIGINT NOT NULL,
system_inactive_memory BIGINT NOT NULL,
system_buffers_memory BIGINT NOT NULL,
system_cached_memory BIGINT NOT NULL,
system_shared_memory BIGINT NOT NULL,
system_avalible_memory BIGINT NOT NULL,
disk_total_memory BIGINT NOT NULL,
disk_used_memory BIGINT NOT NULL,
disk_free_memory BIGINT NOT NULL,
disk_read_count BIGINT NOT NULL,
disk_write_count BIGINT NOT NULL,
disk_read_bytes BIGINT NOT NULL,
disk_write_bytes BIGINT NOT NULL,
time_spent_reading_from_disk BIGINT NOT NULL,
time_spent_writing_to_disk BIGINT NOT NULL,
time_spent_doing_actual_Input_Output BIGINT NOT NULL,
number_of_bytes_sent BIGINT NOT NULL,
number_of_bytes_received BIGINT NOT NULL,
number_of_packets_sent BIGINT NOT NULL,
number_of_packets_recived BIGINT NOT NULL,
total_number_of_errors_while_receiving BIGINT NOT NULL,
total_number_of_errors_while_sending BIGINT NOT NULL,
total_number_of_incoming_packets_which_were_dropped BIGINT NOT NULL,
total_number_of_outgoing_packets_which_were_dropped BIGINT NOT NULL,
boot_time varchar(100) NOT NULL,
keyboard int NOT NULL,
mouse int NOT NULL,
technology varchar(100) NOT NULL,
files_changed int NOT NULL,
CONSTRAINT FK_user_engagemnt_mis_candidates_id FOREIGN KEY (candidate_id) REFERENCES fellowship_candidates (id),
)On partitionbydatescheme(Date_Time)

-- checking wether the table created or not...
select * from Part_UserEngagement_MIS

--inserting the data into the partition table
insert into DatewisePartitionUser_engagement_MIS(id,candidate_id,Date_Time,Cpu_Count,Cpu_Working_Time,Cpu_idle_Time,cpu_percent
,Usage_cpu_count,number_of_software_interrupts_since_boot,number_of_system_calls_since_boot,number_of_interrupts_since_boot,
cpu_avg_load_over_1_min,cpu_avg_load_over_5_min,cpu_avg_load_over_15_min,system_total_memory,system_used_memory,
system_free_memory,system_active_memory,system_inactive_memory,system_buffers_memory,system_cached_memory,system_shared_memory,
system_avalible_memory,disk_total_memory,disk_used_memory,disk_free_memory,disk_read_count,disk_write_count,disk_read_bytes,disk_write_bytes,
time_spent_reading_from_disk,time_spent_writing_to_disk,time_spent_doing_actual_Input_Output,number_of_bytes_sent,number_of_bytes_received,
number_of_packets_sent,number_of_packets_recived,total_number_of_errors_while_sending,total_number_of_errors_while_receiving,total_number_of_incoming_packets_which_were_dropped
,total_number_of_outgoing_packets_which_were_dropped,boot_time,keyboard,mouse,technology,files_changed)
(select * from user_engagement_MIS);