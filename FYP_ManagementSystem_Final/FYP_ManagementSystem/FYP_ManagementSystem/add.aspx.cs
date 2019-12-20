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
    public partial class add : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZUNAIR_HP\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            if (type.SelectedValue == "no")
            {
                des.Enabled = false;
                reg_no.Enabled = false;
            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (type.SelectedValue != "no" && name.Text != "" && fname.Text != "" && (reg_no.Text !="" || des.Text != ""))
            {
                SqlCommand cmd = conn.CreateCommand();
                if (type.SelectedValue == "student")
                {
                    cmd.CommandText = "insert into members values('" + name.Text + "','" + fname.Text + "','" +
                                reg_no.Text + "',' ','" + type.SelectedValue + "')";
                }
                else if (type.SelectedValue == "advisor")
                {
                    cmd.CommandText = "insert into members values('" + name.Text + "','" + fname.Text + "',' ','" +
                                des.Text + "','" + type.SelectedValue + "')";
                }
                cmd.ExecuteNonQuery();
                type.SelectedValue = "no";
                name.Text = "";
                fname.Text = "";
                reg_no.Text = "";
                des.Text = "";
                Response.Write("data inserted!");
            }
            else
            {
                Response.Write("Kindly fill all the details");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.SelectedValue == "student")
            {
                des.Enabled = false;
                reg_no.Enabled = true;
            }
            else if (type.SelectedValue == "advisor")
            {
                des.Enabled = true;
                reg_no.Enabled = false;
            }
        }
    }
}