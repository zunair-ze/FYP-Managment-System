using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace FYP_ManagementSystem
{
    public partial class result : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZUNAIR_HP\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            DisplayRecord();
        }
        
        public DataTable DisplayRecord()
        {
            SqlDataAdapter Adp = new SqlDataAdapter("select * from evaluation", conn);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);
            grid1.DataSource = Dt;
            grid1.DataBind();
            return Dt;
        }

        protected void result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ///Response.Redirect("result.aspx");

            PdfPTable pdftable = new PdfPTable(grid1.HeaderRow.Cells.Count);
            foreach (TableCell headerCell in grid1.HeaderRow.Cells)
            {
                Font font = new Font();
                font.Color = new BaseColor(grid1.HeaderStyle.ForeColor);
                PdfPCell pdfCell = new PdfPCell(new Phrase(headerCell.Text, font));
                pdftable.AddCell(pdfCell);
            }
            foreach (GridViewRow gridViewRow in grid1.Rows)
            {
                foreach (TableCell tableCell in gridViewRow.Cells)
                {
                    PdfPCell pdfCell = new PdfPCell(new Phrase(tableCell.Text));
                    pdftable.AddCell(pdfCell);
                }
            }
            Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

            pdfDocument.Open();
            pdfDocument.Add(pdftable);
            pdfDocument.Close();

            Response.ContentType = "application/pdf";
            Response.AppendHeader("content-disposition", "attachement;filename=Results.pdf");
            Response.Write(pdfDocument);
            Response.Flush();
            Response.End();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}
