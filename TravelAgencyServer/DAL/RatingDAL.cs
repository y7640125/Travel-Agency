using DAL.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RatingDAL
    {
        public void WriteRating(Rating rating)
        {
            string query = "INSERT INTO RATING(HOST, METHOD, PATH, USER_AGENT, Record_Date)"
              + "VALUES(@host, @method, @path, @user_agent, @record_date)";

            using (SqlConnection con = new SqlConnection("Server=MSSQLLocalDB;Database=TravelAgency;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@host", SqlDbType.NVarChar, 50).Value = rating.Host;
                    cmd.Parameters.Add("@method", SqlDbType.NChar, 10).Value = rating.Method;
                    cmd.Parameters.Add("@path", SqlDbType.NVarChar, 50).Value = rating.Path;
                    cmd.Parameters.Add("@user_agent", SqlDbType.NVarChar, -1).Value = rating.UserAgent;
                    cmd.Parameters.Add("@record_date", SqlDbType.DateTime).Value = rating.RecordDate;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
