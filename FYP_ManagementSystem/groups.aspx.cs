using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace FYP_ManagementSystem
{
    public partial class groups : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZUNAIR_HP\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from members where type='student'";
            name1.DataSource = cmd.ExecuteReader();
            name1.DataBind();
            conn.Close();
            conn.Open();

            cmd.CommandText = "select * from members where type='student'";
            name2.DataSource = cmd.ExecuteReader();
            name2.DataBind();
            conn.Close();
            conn.Open();

            cmd.CommandText = "select * from members where type='advisor'";
            advisor.DataSource = cmd.ExecuteReader();
            advisor.DataBind();
            conn.Close();
            conn.Open();

            cmd.CommandText = "select * from projects";
            project.DataSource = cmd.ExecuteReader();
            project.DataBind();
            conn.Close();
            conn.Open();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into groups values('" + name1.SelectedValue + ',' + name2.SelectedValue + "','" + project.SelectedValue + "','" + advisor.SelectedValue + "')";
            cmd.ExecuteNonQuery();
            name1.SelectedValue = "";
        }
    }
}