﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace FYP_ManagementSystem
{
    public partial class project : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZUNAIR_HP\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into projects values('" + name.Text + "')";
            cmd.ExecuteNonQuery();
            name.Text = "";
        }
    }
}