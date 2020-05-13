SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SummaryTableProc]
as
begin
select 
CONCAT(first_name, ' ',middle_name, ' ', last_name) as 'Full Name',
email, candidate_id as "Candidate Id", sum(Cpu_Working_Time) as "Total Cpu Working Time",
sum(Cpu_idle_Time) as "Total Cpu Idle Time",
avg(cpu_percent) as "Cpu Percentage",
sum(number_of_software_interrupts_since_boot) as "Total Number Of Software Interrupts Since Boot",
sum(number_of_interrupts_since_boot) as "Number of Interrupts Since Boot",
avg(cpu_avg_load_over_1_min) as "Average Cpu Load in 1 minute",
avg(cpu_avg_load_over_5_min) as "Average Cpu Load in 5 minutes",
avg(cpu_avg_load_over_15_min) as "Average Cpu Load in 15 Minutes",
sum(disk_read_count) as "Total Disk Reads",
sum(disk_write_count) as "Total Disk Writes",
sum(disk_read_bytes) as "Total Disk Read Bytes",
sum(disk_write_bytes) as "Total Disk Write Bytes",
sum(number_of_bytes_sent) as "Total Number of Bytes Sent",
sum(number_of_bytes_received) as "Total Number of Bytes Received",
sum(number_of_packets_sent) as "Total Number of Packets Sent",
sum(number_of_packets_recived) as "Total Number of Packets Received",
sum(keyboard) as "Total Keyboard Clicks",
sum(mouse) as "Total mouse Clicks",
sum(files_changed) as "Total Files changed"
FROM [UserEngagementDB].[dbo].[user_engagement_MIS] join fellowship_candidates
on user_engagement_MIS.candidate_id=fellowship_candidates.id
group by candidate_id, email, first_name, last_name, middle_name
order by candidate_id
end