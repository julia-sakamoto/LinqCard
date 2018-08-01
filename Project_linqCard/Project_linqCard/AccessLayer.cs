using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;

namespace Project_linqcard
{
    public class Student
    {

        public int Id { get; set; }
        public string St_Name { get; set; }
    }


    public class Company
    {
        public string companyID { get; set; }
        public string companySite { get; set; }
        public string companyName { get; set; }
        public string companyType { get; set; }
        public string companyInfo { get; set; }
        public string ceoName { get; set; }
    }


    public class AccessLayer
    {
        public static List<Company> getCompanies(string companyType)
        {
            List<Company> listCompany = new List<Company>();
            //todo modify webconfig
            string cs = ConfigurationManager.ConnectionStrings["LinqConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from Company where companyType='" + companyType + "'", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Company obj = new Company();
                    obj.companyID = rdr["CompanyId"].ToString();
                    obj.companySite = rdr["CompanyWebsite"].ToString();
                    obj.companyInfo = rdr["CompanyInfo"].ToString();
                    obj.ceoName = rdr["CeoName"].ToString();
                    obj.companyType = rdr["CompanyType"].ToString();
                    obj.companyName = rdr["CompanyName"].ToString();
                    listCompany.Add(obj);
                }
            }

            return listCompany;
        }

        public static void addRecord(Student obj)
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("insert into student values (@Id,@St_Name)", con);
                con.Open();
                cmd.Parameters.AddWithValue("Id", obj.Id);
                cmd.Parameters.AddWithValue("St_Name", obj.St_Name);

                cmd.ExecuteNonQuery();

            }
        }

        public static void deleteRecord(Student obj)
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("delete from student where Id=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("Id", obj.Id);
                cmd.ExecuteNonQuery();

            }
        }

        public static void updateRecord(Student obj)
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("update student set St_Name=@Name where Id=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("Id", obj.Id);
                cmd.Parameters.AddWithValue("Name", obj.St_Name);
                cmd.ExecuteNonQuery();

            }
        }

    }

}