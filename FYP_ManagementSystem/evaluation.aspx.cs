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
    public partial class evaluation : System.Web.UI.Page
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
                show();
            }
        }

        protected void add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into evaluation values('" + g.SelectedValue + "','" + total.Text + "','" + obtained.Text + "')";
            cmd.ExecuteNonQuery();
        }
        protected void show()
        {
            SqlCommand cmd = new SqlCommand("select * from groups", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            g.DataSource = ds;
            g.DataTextField = "students";
            g.DataBind();
            g.Items.Insert(0, new ListItem("Select a group", "0"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}
