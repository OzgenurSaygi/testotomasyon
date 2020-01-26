using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication3
{
    public partial class DersAtamalariSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelen = Session["girissicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + gelen;
            }
            int dersatamaid = Convert.ToInt32(Request.QueryString["ders_atama_id"]);
            int sicilno = Convert.ToInt32(Request.QueryString["sicil_no"]);
            string adi = Request.QueryString["adi"];
            string dersadi = Request.QueryString["dersadi"];

            dersatamasilid.Text = dersatamaid.ToString();
            dersatamasilsicilno.Text = sicilno.ToString();
            dersatamasilad.Text = adi;
            dersatamasilders.Text = dersadi;


        }

        protected void btnkaydet_Click(object sender, EventArgs e)
        {
            int dersatamaid = Convert.ToInt32(Request.QueryString["ders_atama_id"]);
            string bolumadi = Request.QueryString["ders_atama_id"];
            SqlConnection con;
            SqlCommand cmd, cmd2;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            con.Open();
            cmd = new SqlCommand("DELETE FROM ders_atama_bilgileri WHERE ders_atama_id=@ders_atama_id", con);
            cmd.Parameters.AddWithValue("@ders_atama_id", dersatamaid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}