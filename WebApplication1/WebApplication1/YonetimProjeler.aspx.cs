using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Duzenle_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            string gvr1 = gvr.Cells[0].Text;
            Session.Add("id", gvr1);
            Session.Add("Sayfa", "YonetimProjeler.aspx");
            Response.Redirect("YonetimDuzenle.aspx");
        }
    }
}