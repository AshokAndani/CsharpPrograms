using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using OfficeOpenXml.FormulaParsing.Utilities;
using UserEngagementSystem.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserEngagementSystem.Controllers
{
    public class MISController : Controller
    {
        IHostingEnvironment hostingEnvironment;
        private readonly IConfiguration configuration;

        public MISController(IHostingEnvironment environment, IConfiguration configuration)
        {
            this.hostingEnvironment = environment;
            this.configuration = configuration;
        }
        [HttpGet("GetSummary")]
        public async Task<IActionResult> ExportV2(CancellationToken cancellationToken)
        {
            // query data from database  
            await Task.Yield();
            var list = new List<SummaryTable>();
            var ConnectionString = configuration["Connection"];
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from SummaryTable", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    SummaryTable user = new SummaryTable();

                    user.Email = dataReader.GetString(0);
                    user.FullName = dataReader.GetString(1);
                    user.Candidate_Id = dataReader.GetInt32(2);
                    user.Total_Cpu_Working_Time = dataReader.GetDecimal(3);
                    user.Total_Cpu_Idle_Time = dataReader.GetDecimal(4);
                    user.Cpu_Percentage = dataReader.GetDecimal(5);
                    user.Total_Number_Of_Software_Interrupts_Since_Boot = dataReader.GetDecimal(6);
                    user.Number_Of_Interrupts_Since_Boot = dataReader.GetInt32(7);
                    user.Average_Cpu_Load_in_1_Minutes = dataReader.GetDecimal(8);
                    user.Average_Cpu_Load_in_5_Minutes = dataReader.GetDecimal(9);
                    user.Average_Cpu_Load_in_15_Minutes = dataReader.GetDecimal(10);
                    user.Total_Disk_Reads = (long)dataReader.GetSqlInt64(11);
                    user.Total_Disk_Writes = (long)dataReader.GetSqlInt64(12);
                    user.Total_Disk_Read_Bytes = dataReader.GetInt64(13);
                    user.Total_Disk_Write_Bytes = dataReader.GetInt64(14);
                    user.Total_Number_Of_Bytes_Sent = dataReader.GetInt64(15);
                    user.Total_Number_Of_Bytes_Recieved = dataReader.GetInt64(16);
                    user.Total_Number_Of_Packets_Sent = dataReader.GetInt64(17);
                    user.Total_Numbet_Of_Packets_Received = dataReader.GetInt64(18);
                    user.Total_KeyBoard_Clicks = dataReader.GetInt32(19);
                    user.Total_Mouse_Clicks = dataReader.GetInt32(20);
                    user.Total_Files_Changed = dataReader.GetInt32(21);
                    list.Add(user);
                }
                con.Close();
            }
            var stream = new MemoryStream();

            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");
                workSheet.Cells.LoadFromCollection(list, true);
                package.Save();
            }
            stream.Position = 0;
            string excelName = $"SummaryTable-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";

            //return File(stream, "application/octet-stream", excelName);  
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
        }
    }
}
