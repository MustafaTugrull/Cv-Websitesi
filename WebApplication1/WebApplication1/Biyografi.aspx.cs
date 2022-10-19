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
    public partial class Biyografi : System.Web.UI.Page
    {
        public string Icerik1_biyografi = "";
        public string Ilkokul = "";
        public string Lise = "";
        public string Universite = "";
        public string Icerik1_footer = "";
        public string Icerik1_2_footer = "";
        public string Adres1_2 = "";
        public string Mail1 = "";

        DataTable tablo = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-VV7KTR3;Database=webprojesi;User Id=sa;Password=abc123;");


            String query = "SELECT * FROM METIN";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(tablo);
            Icerik1_biyografi = Convert.ToString(tablo.Select("TITLE = 'Icerik1' AND ICERIK = 'BIYOGRAFI'")[0][3]);
            Ilkokul = Convert.ToString(tablo.Select("TITLE = 'Ilkokul' AND ICERIK = 'HAKKINDA'")[0][3]);
            Lise = Convert.ToString(tablo.Select("TITLE = 'Lise' AND ICERIK = 'HAKKINDA'")[0][3]);
            Universite = Convert.ToString(tablo.Select("TITLE = 'Universite' AND ICERIK = 'HAKKINDA'")[0][3]);
            Icerik1_footer = Convert.ToString(tablo.Select("TITLE = 'Icerik1' AND ICERIK = 'FOOTER'")[0][3]);
            Icerik1_2_footer = Convert.ToString(tablo.Select("TITLE = 'Icerik1_2' AND ICERIK = 'FOOTER'")[0][3]);
            Adres1_2 = Convert.ToString(tablo.Select("TITLE = 'Adres1_2' AND ICERIK = 'ILETISIM'")[0][3]);
            Mail1 = Convert.ToString(tablo.Select("TITLE = 'Mail1' AND ICERIK = 'ILETISIM'")[0][3]);

            Literal1.Text = Icerik1_biyografi;
            Literal2.Text = Ilkokul;
            Literal3.Text = Lise;
            Literal4.Text = Universite;
            Literal5.Text = Icerik1_footer;
            Literal6.Text = Icerik1_2_footer;
            Literal7.Text = Adres1_2;
            Literal8.Text = Mail1;

            connection.Close();
        }
    }
}