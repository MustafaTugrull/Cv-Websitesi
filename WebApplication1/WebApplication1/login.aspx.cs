using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void btnlogin_Click1(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Server=DESKTOP-VV7KTR3;Database=webprojesi;User Id=sa;Password=abc123;");

            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM KULLANICILAR WHERE USERNAME=@P1 AND PASSWORD=@P2", connection);
            command.Parameters.AddWithValue("@P1", loginusername.Text);
            command.Parameters.AddWithValue("@P2", loginpassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("yonetimAnasayfa.aspx");
            }
            else
            {
                Response.Write("<script>alert('Kullanıcı Adı Ya da Şifre Yanlış!')</script>");
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}