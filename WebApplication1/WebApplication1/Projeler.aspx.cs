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
    public partial class Projeler : System.Web.UI.Page
    {
        public string Icerik1_footer = "";
        public string Icerik1_2_footer = "";
        public string Adres1_2 = "";
        public string Mail1 = "";
        public string Icerik2 = "";
        public string Icerik2_2 = "";
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

            Icerik1_footer = Convert.ToString(tablo.Select("TITLE = 'Icerik1' AND ICERIK = 'FOOTER'")[0][3]);
            Icerik1_2_footer = Convert.ToString(tablo.Select("TITLE = 'Icerik1_2' AND ICERIK = 'FOOTER'")[0][3]);
            Adres1_2 = Convert.ToString(tablo.Select("TITLE = 'Adres1_2' AND ICERIK = 'ILETISIM'")[0][3]);
            Mail1 = Convert.ToString(tablo.Select("TITLE = 'Mail1' AND ICERIK = 'ILETISIM'")[0][3]);
            Icerik2 = Convert.ToString(tablo.Select("TITLE = 'Icerik2' AND ICERIK = 'ANASAYFA'")[0][3]);
            Icerik2_2 = Convert.ToString(tablo.Select("TITLE = 'Icerik2_2' AND ICERIK = 'ANASAYFA'")[0][3]);
            C1 = Convert.ToString(tablo.Select("TITLE = 'C++' AND ICERIK = 'PROJELER'")[0][3]);
            C2 = Convert.ToString(tablo.Select("TITLE = 'C#' AND ICERIK = 'PROJELER'")[0][3]);
            JAVA = Convert.ToString(tablo.Select("TITLE = 'JAVA' AND ICERIK = 'PROJELER'")[0][3]);

            Literal1.Text = Icerik1_footer;
            Literal2.Text = Icerik1_2_footer;
            Literal3.Text = Adres1_2;
            Literal4.Text = Mail1;
            Literal5.Text = Icerik2;
            Literal6.Text = Icerik2_2;
            Literal7.Text = C1;
            Literal8.Text = C2;
            Literal9.Text = JAVA;

            connection.Close();
        }
    }
}