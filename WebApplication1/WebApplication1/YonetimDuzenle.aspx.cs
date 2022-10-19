using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        DataTable tablo = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            { }
            else
                {
                    SqlConnection connection = new SqlConnection("Server=DESKTOP-VV7KTR3;Database=webprojesi;User Id=sa;Password=abc123;");

                    String query = "SELECT * FROM METIN";

                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    command.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(tablo);
                    Icerik1.Text = Convert.ToString(tablo.Select("ID ='" + Session["ID"].ToString() + "'")[0][1]);
                    Title1.Text = Convert.ToString(tablo.Select("ID ='" + Session["ID"].ToString() + "'")[0][2]);
                    Metin1.Text = Convert.ToString(tablo.Select("ID ='" + Session["ID"].ToString() + "'")[0][3]);
                    connection.Close();
                }
            }
            protected void btnDuzenle_Click1(object sender, EventArgs e)
            {
                SqlConnection connection = new SqlConnection("Server=DESKTOP-VV7KTR3;Database=webprojesi;User Id=sa;Password=abc123;");

                String query = "UPDATE METIN SET METIN='" + Metin1.Text + "' WHERE ID='" + Session["ID"].ToString() + "'";

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
                connection.Close();
                Response.Redirect(Session["Sayfa"].ToString());
            }

            protected void btnIptal_Click1(object sender, EventArgs e)
            {

                Response.Redirect(Session["Sayfa"].ToString());
            }
        }
    }