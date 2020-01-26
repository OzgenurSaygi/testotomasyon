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
    public partial class KullaniciSil : System.Web.UI.Page
       
    {
         protected void Page_Load(object sender, EventArgs e)
        {
            string gelen = Session["girissicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + gelen;
            }
            int sicilno = Convert.ToInt32(Request.QueryString["sicil_no"]);
              string adi = Request.QueryString["adi"];
             string soyadi = Request.QueryString["soyadi"];

            kullanicisilad.Text = adi;
            kullanicisilsicil.Text = sicilno.ToString();
            kullanicisilsoyad.Text = soyadi;
        }

        protected void btnkaydet_Click(object sender, EventArgs e)
        {
            int sicilno = Convert.ToInt32(Request.QueryString["sicil_no"]);
            string adi = Request.QueryString["adi"];
            string soyadi = Request.QueryString["soyadi"];
            SqlConnection con;
            SqlCommand cmd, cmd2,cmd3,cmd4,cmd5;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            con.Open();
            cmd = new SqlCommand("DELETE FROM Egitimci_Bilgileri_Db WHERE sicil_no=@sicil_no", con);
            cmd.Parameters.AddWithValue("@sicil_no", sicilno);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd2 = new SqlCommand("DELETE FROM ders_atama_bilgileri WHERE sicil_no=@sicil_no", con);
            cmd2.Parameters.AddWithValue("@sicil_no", sicilno);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            cmd3 = new SqlCommand("DELETE FROM kazanim_bazli_okutma WHERE sicil_no=@sicil_no", con);
            cmd3.Parameters.AddWithValue("@sicil_no", sicilno);
            cmd3.ExecuteNonQuery();
            cmd3.Dispose();
            cmd4 = new SqlCommand("DELETE FROM sinav_sonucu_okutma WHERE sicil_no=@sicil_no", con);
            cmd4.Parameters.AddWithValue("@sicil_no", sicilno);
            cmd4.ExecuteNonQuery();
            cmd4.Dispose();
            cmd5 = new SqlCommand("DELETE FROM soru_bazli_okutma WHERE sicil_no=@sicil_no", con);
            cmd5.Parameters.AddWithValue("@sicil_no", sicilno);
            cmd5.ExecuteNonQuery();
            cmd5.Dispose();
            con.Close();

        }
    }
}