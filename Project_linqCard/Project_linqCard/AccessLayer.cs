﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;

namespace Project_linqcard
{

    public class Company
    {
        public int companyID { get; set; }
        public string companySite { get; set; }
        public string companyName { get; set; }
        public string companyType { get; set; }
        public string companyInfo { get; set; }
        public string ceoName { get; set; }
    }

    public class BusinessCard
    {
        public int companyID { get; set; }
        public int employerID { get; set; }
        public string name { get; set; }
        public string jobTitle { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string email { get; set; }
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
                    obj.companyID = int.Parse(rdr["CompanyId"].ToString());
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

        public static List<BusinessCard> getBusinessCards(int companyID)
        {
            List<BusinessCard> listCards = new List<BusinessCard>();
            //todo modify webconfig
            string cs = ConfigurationManager.ConnectionStrings["LinqConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from Employee where companyID = '" + companyID + "'", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    BusinessCard obj = new BusinessCard();
                    obj.employerID = Convert.ToInt32(rdr["employeeID"]);

                    obj.name = rdr["name"].ToString();
                    obj.address = rdr["address"].ToString();
                    obj.email = rdr["email"].ToString();
                    obj.jobTitle = rdr["jobTitle"].ToString();
                    obj.phoneNumber = rdr["phoneNumber"].ToString();
                    listCards.Add(obj);
                }
            }

            return listCards;
        }


        public static void addRecord(BusinessCard obj)
        {
            string cs = ConfigurationManager.ConnectionStrings["LinqConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("insert into Employee (Name, JobTitle, PhoneNumber, Address, Email, CompanyId) values (@Name, @JobTitle, @PhoneNumber, @Address, @Email, @CompanyId)", con);
                con.Open();
                cmd.Parameters.AddWithValue("Name", obj.name);
                cmd.Parameters.AddWithValue("JobTitle", obj.jobTitle);
                cmd.Parameters.AddWithValue("PhoneNumber", obj.phoneNumber);
                cmd.Parameters.AddWithValue("Address", obj.address);
                cmd.Parameters.AddWithValue("Email", obj.email);
                cmd.Parameters.AddWithValue("CompanyId", obj.companyID);

                cmd.ExecuteNonQuery();
            }
        }

        public static void deleteRecord(BusinessCard card)
        {

            string cs = ConfigurationManager.ConnectionStrings["LinqConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("delete from Employee where employeeID=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("Id", card.employerID);
                cmd.ExecuteNonQuery();

            }
        }

        public static void updateRecord(BusinessCard card)
        {
            string cs = ConfigurationManager.ConnectionStrings["LinqConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("update Employee set name=@Name,address=@Address,phoneNumber=@phoneNumber," +
                    "email=@email,jobTitle=@jobTitle where employeeID=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("Id", card.employerID);
                cmd.Parameters.AddWithValue("Name", card.name);
                cmd.Parameters.AddWithValue("Address", card.address);
                cmd.Parameters.AddWithValue("phoneNumber", card.phoneNumber);
                cmd.Parameters.AddWithValue("email", card.email);
                cmd.Parameters.AddWithValue("jobTitle", card.jobTitle);

                cmd.ExecuteNonQuery();

            }
        }

    }

}