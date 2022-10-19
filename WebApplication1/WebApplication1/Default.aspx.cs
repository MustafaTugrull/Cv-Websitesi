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
    public partial class Default : System.Web.UI.Page
    {
        public string Icerik1 = "";
        public string Icerik1_2 = "";
        public string Icerik1_3 = "";
        public string Icerik2 = "";
        public string Icerik2_2 = "";
        public string Icerik3 = "";
        public string Icerik3_2 = "";
        public string Icerik1_biyografi = "";
        public string Adres1_2 = "";
        public string Adres1 = "";
        public string Ilkokul = "";
        public string Lise = "";
        public string Universite = "";
        public string Icerik1_footer = "";
        public string Icerik1_2_footer = "";
        public string Mail1 = "";
        public string C1 = "";
        public string C2 = "";
        public string JAVA = "";

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
            Icerik1 = Convert.ToString(tablo.Select("TITLE = 'Icerik1' AND ICERIK = 'ANASAYFA'")[0][3]);
            Icerik1_2 = Convert.ToString(tablo.Select("TITLE = 'Icerik1_2' AND ICERIK = 'ANASAYFA'")[0][3]);
            Icerik1_3 = Convert.ToString(tablo.Select("TITLE = 'Icerik1_3' AND ICERIK = 'ANASAYFA'")[0][3]);
            Icerik2 = Convert.ToString(tablo.Select("TITLE = 'Icerik2' AND ICERIK = 'ANASAYFA'")[0][3]);
            Icerik2_2 = Convert.ToString(tablo.Select("TITLE = 'Icerik2_2' AND ICERIK = 'ANASAYFA'")[0][3]);
            Icerik3 = Convert.ToString(tablo.Select("TITLE = 'Icerik3' AND ICERIK = 'ANASAYFA'")[0][3]);
            Icerik3_2 = Convert.ToString(tablo.Select("TITLE = 'Icerik3_2' AND ICERIK = 'ANASAYFA'")[0][3]);
            Icerik1_biyografi = Convert.ToString(tablo.Select("TITLE = 'Icerik1' AND ICERIK = 'BIYOGRAFI'")[0][3]);
            Adres1_2 = Convert.ToString(tablo.Select("TITLE = 'Adres1_2' AND ICERIK = 'ILETISIM'")[0][3]);
            Adres1 = Convert.ToString(tablo.Select("TITLE = 'Adres1' AND ICERIK = 'ILETISIM'")[0][3]);
            Ilkokul = Convert.ToString(tablo.Select("TITLE = 'Ilkokul' AND ICERIK = 'HAKKINDA'")[0][3]);
            Lise = Convert.ToString(tablo.Select("TITLE = 'Lise' AND ICERIK = 'HAKKINDA'")[0][3]);
            Universite = Convert.ToString(tablo.Select("TITLE = 'Universite' AND ICERIK = 'HAKKINDA'")[0][3]);
            Icerik1_footer = Convert.ToString(tablo.Select("TITLE = 'Icerik1' AND ICERIK = 'FOOTER'")[0][3]);
            Icerik1_2_footer = Convert.ToString(tablo.Select("TITLE = 'Icerik1_2' AND ICERIK = 'FOOTER'")[0][3]);
            Mail1 = Convert.ToString(tablo.Select("TITLE = 'Mail1' AND ICERIK = 'ILETISIM'")[0][3]);
            C1 = Convert.ToString(tablo.Select("TITLE = 'C++' AND ICERIK = 'PROJELER'")[0][3]);
            C2 = Convert.ToString(tablo.Select("TITLE = 'C#' AND ICERIK = 'PROJELER'")[0][3]);
            JAVA = Convert.ToString(tablo.Select("TITLE = 'JAVA' AND ICERIK = 'PROJELER'")[0][3]);

            Literal1.Text = Icerik1;
            Literal2.Text = Icerik1_2;
            Literal3.Text = Icerik1_3;
            Literal4.Text = Icerik2;
            Literal5.Text = Icerik2_2;
            Literal6.Text = Icerik3;
            Literal7.Text = Icerik3_2;
            Literal8.Text = Icerik1_biyografi;
            Literal9.Text = Adres1_2;
            Literal10.Text = Adres1;
            Literal11.Text = Ilkokul;
            Literal12.Text = Lise;
            Literal13.Text = Universite;
            Literal14.Text = Icerik1_footer;
            Literal15.Text = Icerik1_2_footer;
            Literal16.Text = Adres1_2;
            Literal17.Text = Mail1;
            Literal18.Text = C1;
            Literal19.Text = C2;
            Literal20.Text = JAVA;

            connection.Close();
        }
    }
}