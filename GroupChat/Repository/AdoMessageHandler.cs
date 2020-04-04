// <copyright file="AdoMessageHandler.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace GroupChat.Repository
{
   using System;
   using System.Collections.Generic;
   using System.Data;
   using System.Data.SqlClient;
   using System.Linq;
   using System.Threading.Tasks;
    public class AdoMessageHandler : IMessageHandler
    {
        string ConnectionString = "Server=localhost;Database=GroupChattDB;Trusted_Connection=True;";
        public void AddMessages(UserAndMessage user)
        {
            using(SqlConnection con=new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SocketID",user.SocketID);
                cmd.Parameters.AddWithValue("@GroupName", user.GroupName);
                cmd.Parameters.AddWithValue("@Message", user.Message);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteMessages(string userID)
        {

        }

        public IEnumerable<UserAndMessage> GetAllMessages()
        {
            List<UserAndMessage> users = new List<UserAndMessage>();
            using(SqlConnection con=new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GETALL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    UserAndMessage user = new UserAndMessage();
                    user.GroupName = dataReader["GroupName"].ToString();
                    user.Message= dataReader["Message"].ToString();
                    user.SocketID= dataReader["SocketID"].ToString();
                    users.Add(user);
                }
                con.Close();
                return users;
            }
        }
    }
}
