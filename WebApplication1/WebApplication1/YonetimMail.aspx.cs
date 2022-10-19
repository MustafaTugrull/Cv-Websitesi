using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Sil_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            string gvr1 = gvr.Cells[0].Text;

            SqlConnection connection = new SqlConnection("Server=DESKTOP-VV7KTR3;Database=webprojesi;User Id=sa;Password=abc123;");


            String query = "DELETE FROM Mails WHERE id='" + gvr1 + "'";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
            connection.Close();
            Response.Redirect("YonetimMail.aspx");

        }
    }
}