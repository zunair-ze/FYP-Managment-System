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
                DisplayRecord();
            }
        }
        public DataTable DisplayRecord()
        {
            SqlDataAdapter Adp = new SqlDataAdapter("select * from groups", conn);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);
            g.DataSource = Dt;
            g.DataBind();
            return Dt;
        }
        protected void add_Click(object sender, EventArgs e)
        {
            if (ddlCountry.SelectedValue != name2.SelectedValue)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into groups values('" + ddlCountry.SelectedValue + "," + name2.SelectedValue + "','" + project.SelectedValue + "','" + advisor.SelectedValue + "')";
                cmd.ExecuteNonQuery();
                Response.Write("group uploaded!");
            }
            else
            {
                Response.Write("error in group making");
            }
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
            ddlCountry.Items.Insert(0, new ListItem("First Student", "0"));
            name2.Items.Insert(0, new ListItem("Second student", "0"));
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void g_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}