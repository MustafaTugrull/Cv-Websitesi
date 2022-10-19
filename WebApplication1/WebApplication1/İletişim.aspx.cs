using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class İletişim : System.Web.UI.Page
    {
        public string Icerik1_footer = "";
        public string Icerik1_2_footer = "";
        public string Adres1_2 = "";
        public string Mail1 = "";
        public string Mail1_2 = "";
        public string Telefon1 = "";
        public string Telefon1_2 = "";
        public string Adres1 = "";


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
            Mail1_2 = Convert.ToString(tablo.Select("TITLE = 'Mail1_2' AND ICERIK = 'ILETISIM'")[0][3]);
            Telefon1 = Convert.ToString(tablo.Select("TITLE = 'Telefon1' AND ICERIK = 'ILETISIM'")[0][3]);
            Telefon1_2 = Convert.ToString(tablo.Select("TITLE = 'Telefon1_2' AND ICERIK = 'ILETISIM'")[0][3]);
            Adres1 = Convert.ToString(tablo.Select("TITLE = 'Adres1' AND ICERIK = 'ILETISIM'")[0][3]);

            Literal1.Text = Icerik1_footer;
            Literal2.Text = Icerik1_2_footer;
            Literal3.Text = Adres1_2;
            Literal4.Text = Mail1;
            Literal5.Text = Mail1;
            Literal6.Text = Mail1_2;
            Literal7.Text = Telefon1;
            Literal8.Text = Telefon1_2;
            Literal9.Text = Adres1;
            Literal10.Text = Adres1_2;



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-VV7KTR3;Database=webprojesi;User Id=sa;Password=abc123;");


            String query = "INSERT INTO Mails (name,mailAdress,titlesubject,message,senddate) VALUES (@name,@mailAdress,@titlesubject,@message,@senddate)";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@name", name.Text);
            command.Parameters.Add("@mailAdress", email.Text);
            command.Parameters.Add("@titlesubject", subject.Text);
            command.Parameters.Add("@message", message1.Text);
            command.Parameters.Add("@senddate", DateTime.Now);

            command.ExecuteNonQuery();
            connection.Close();



            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("mustafamustafa1327@hotmail.com");
            mail.To.Add("mustafamustafa1327@hotmail.com");
            mail.Subject = subject.Text;
            mail.Body = message1.Text + "<br>" + "<br>" + "MAIL: " + email.Text;
            mail.IsBodyHtml = true;

            SmtpClient message = new SmtpClient();
            message.Credentials = new NetworkCredential("mustafamustafa1327@hotmail.com", "tugrul0501");
            message.Port = 587;
            message.Host = "smtp.live.com";
            message.EnableSsl = true;
            message.Send(mail);

            message1.Text = "";
            name.Text = "";
            email.Text = "";
            subject.Text = "";




        }
    }
}