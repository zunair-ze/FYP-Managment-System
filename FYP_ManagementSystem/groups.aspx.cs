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

            if (!IsPostBack)
            {
                showName();
                showAdvisor();
                showProject();
            }
        }

        protected void add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into groups values('" + ddlCountry.SelectedValue + ',' + name2.SelectedValue + "','" + project.SelectedValue + "','" + advisor.SelectedValue + "')";
            cmd.ExecuteNonQuery();
        }
        protected void showName()
        {
            SqlCommand cmd = new SqlCommand("select * from members where type='student'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            name2.DataSource = ddlCountry.DataSource = ds;
            name2.DataTextField = ddlCountry.DataTextField = "name";
            ddlCountry.DataBind();
            name2.DataBind();
            ddlCountry.Items.Insert(0, new ListItem("Select first Student", "0"));
            name2.Items.Insert(0, new ListItem("Select second Student", "0"));
        }
        protected void showAdvisor()
        {
            SqlCommand cmd = new SqlCommand("select * from members where type='advisor'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            advisor.DataSource = ds;
            advisor.DataTextField = "name";
            advisor.DataBind();
            advisor.Items.Insert(0, new ListItem("Select Advisor", "0"));
        }
        protected void showProject()
        {
            SqlCommand cmd = new SqlCommand("select * from projects", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            project.DataSource = ds;
            project.DataTextField = "name";
            project.DataBind();
            project.Items.Insert(0, new ListItem("Select Project", "0"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}
