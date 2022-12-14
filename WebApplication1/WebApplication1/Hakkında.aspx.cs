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
    public partial class Hakkında : System.Web.UI.Page
    {
        public string Icerik1_footer = "";
        public string Icerik1_2_footer = "";
        public string Adres1_2 = "";
        public string Mail1 = "";
        public string Ilkokul = "";
        public string Lise = "";
        public string Universite = "";
        public string Icerik3 = "";
        public string Icerik3_2 = "";

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

            Icerik1_footer = Convert.ToString(tablo.Select("TITLE = 'Icerik1' AND ICERIK = 'FOOTER'")[0][3]);
            Icerik1_2_footer = Convert.ToString(tablo.Select("TITLE = 'Icerik1_2' AND ICERIK = 'FOOTER'")[0][3]);
            Adres1_2 = Convert.ToString(tablo.Select("TITLE = 'Adres1_2' AND ICERIK = 'ILETISIM'")[0][3]);
            Mail1 = Convert.ToString(tablo.Select("TITLE = 'Mail1' AND ICERIK = 'ILETISIM'")[0][3]);
            Ilkokul = Convert.ToString(tablo.Select("TITLE = 'Ilkokul' AND ICERIK = 'HAKKINDA'")[0][3]);
            Lise = Convert.ToString(tablo.Select("TITLE = 'Lise' AND ICERIK = 'HAKKINDA'")[0][3]);
            Universite = Convert.ToString(tablo.Select("TITLE = 'Universite' AND ICERIK = 'HAKKINDA'")[0][3]);
            Icerik3 = Convert.ToString(tablo.Select("TITLE = 'Icerik3' AND ICERIK = 'ANASAYFA'")[0][3]);
            Icerik3_2 = Convert.ToString(tablo.Select("TITLE = 'Icerik3_2' AND ICERIK = 'ANASAYFA'")[0][3]);

            Literal1.Text = Icerik1_footer;
            Literal2.Text = Icerik1_2_footer;
            Literal3.Text = Adres1_2;
            Literal4.Text = Mail1;
            Literal5.Text = Ilkokul;
            Literal6.Text = Lise;
            Literal7.Text = Universite;
            Literal8.Text = Icerik3;
            Literal9.Text = Icerik3_2;

            connection.Close();

        }
    }
}