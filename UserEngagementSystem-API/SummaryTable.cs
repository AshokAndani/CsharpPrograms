using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserEngagementSystem.Controllers
{
    public class SummaryTable
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Candidate_Id { get; set; }
        public decimal Total_Cpu_Working_Time { get; set; }
        public decimal Total_Cpu_Idle_Time { get; set; }
        public decimal Cpu_Percentage { get; set; }
        public decimal Total_Number_Of_Software_Interrupts_Since_Boot { get; set; }
        public long Number_Of_Interrupts_Since_Boot { get; set; }
        public decimal Average_Cpu_Load_in_1_Minutes { get; set; }
        public decimal Average_Cpu_Load_in_5_Minutes { get; set; }
        public decimal Average_Cpu_Load_in_15_Minutes { get; set; }
        public long Total_Disk_Reads { get; set; }
        public long Total_Disk_Writes { get; set; }
        public long Total_Disk_Read_Bytes { get; set; }
        public long Total_Disk_Write_Bytes { get; set; }
        public long Total_Number_Of_Bytes_Sent { get; set; }
        public long Total_Number_Of_Bytes_Recieved { get; set; }
        public  long Total_Number_Of_Packets_Sent { get; set; }
        public long  Total_Numbet_Of_Packets_Received { get; set; }
        public int Total_KeyBoard_Clicks { get; set; }
        public int Total_Mouse_Clicks { get; set; }
        public int Total_Files_Changed { get; set; }
    }
}
