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
    public partial class DersleriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelen = Session["girissicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + gelen;
            }
            int derskodu = Convert.ToInt32(Request.QueryString["derskodu"]);
            string dersadi = Request.QueryString["dersadi"];
            derssilad.Text = dersadi;
            derssilkod.Text = derskodu.ToString();
        }

        protected void btnkaydet_Click(object sender, EventArgs e)
        {
            int derskodu = Convert.ToInt32(Request.QueryString["ders_kodu"]);
            string dersadi = Request.QueryString["ders_adi"];
            SqlConnection con;
            SqlCommand cmd, cmd2, cmd3, cmd4, cmd5,cmd6;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            con.Open();
            cmd = new SqlCommand("DELETE FROM ders_bilgileri WHERE ders_kodu=@ders_kodu", con);
            cmd.Parameters.AddWithValue("@ders_kodu", derskodu);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd2 = new SqlCommand("DELETE FROM ogrenme_ciktilari WHERE ders_kodu=@ders_kodu", con);
            cmd2.Parameters.AddWithValue("@ders_kodu", derskodu);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            cmd3 = new SqlCommand("DELETE FROM ders_atama_bilgileri WHERE ders_kodu=@ders_kodu", con);
            cmd3.Parameters.AddWithValue("@ders_kodu", derskodu);
            cmd3.ExecuteNonQuery();
            cmd3.Dispose();
            cmd4 = new SqlCommand("DELETE FROM kazanim_bazli_okutma WHERE ders_kodu=@ders_kodu", con);
            cmd4.Parameters.AddWithValue("@ders_kodu", derskodu);
            cmd4.ExecuteNonQuery();
            cmd4.Dispose();
            cmd5 = new SqlCommand("DELETE FROM soru_bazli_okutma WHERE ders_kodu=@ders_kodu", con);
            cmd5.Parameters.AddWithValue("@ders_kodu", derskodu);
            cmd5.ExecuteNonQuery();
            cmd5.Dispose();
            cmd6 = new SqlCommand("DELETE FROM sinav_sonucu_oktma WHERE ders_kodu=@ders_kodu", con);
            cmd6.Parameters.AddWithValue("@ders_kodu", derskodu);
            cmd6.ExecuteNonQuery();
            cmd6.Dispose();
            con.Close();
        }
    }
}