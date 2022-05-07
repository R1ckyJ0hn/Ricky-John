using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using ClinicDeskApplication.Models;
using System.Data;

namespace ClinicDeskApplication.DAL
{
    public class ClinicDAL
    {
        public string cnn = "";


        public ClinicDAL()
        {

            var builder = new ConfigurationBuilder().SetBasePath
                    (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:NewConn").Value;
        }

        public int AddDoctors(Doctor doc)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("AddDoctors", con);
                    
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", doc.FirstName);
            cmd.Parameters.AddWithValue("@lname", doc.LastName);
            cmd.Parameters.AddWithValue("@gen", doc.Sex);
            cmd.Parameters.AddWithValue("@spec", doc.Specialization);
            cmd.Parameters.AddWithValue("@vis", doc.VisitingHours);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int AddPatient(Patient pat)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("AddPatients", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", pat.FirstName);
            cmd.Parameters.AddWithValue("@lname", pat.LastName);
            cmd.Parameters.AddWithValue("@sex", pat.Sex);
            cmd.Parameters.AddWithValue("@age", pat.Age);
            cmd.Parameters.AddWithValue("@dob", pat.DateofBirth);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }


    }
}
