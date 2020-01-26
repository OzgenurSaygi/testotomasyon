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
    public partial class BolumSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelen = Session["girissicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + gelen;
            }
            int bolumid = Convert.ToInt32(Request.QueryString["bolum_id"]);
            string bolumadi = Request.QueryString["bolum_adi"];

            silmebolumad.Text = bolumadi;
            silmebolumid.Text = bolumid.ToString();
           
          

        }

        protected void btnkaydet_Click(object sender, EventArgs e)
        {
            int bolumid = Convert.ToInt32(Request.QueryString["bolum_id"]);
            string bolumadi = Request.QueryString["bolum_adi"];
            SqlConnection con;
            SqlCommand cmd,cmd2,cmd3,cmd4,cmd5,cmd6,cmd7;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            con.Open();
            cmd = new SqlCommand("DELETE FROM bolum_bilgileri WHERE bolum_id=@bolum_id", con);
            cmd.Parameters.AddWithValue("@bolum_id",bolumid);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd2 = new SqlCommand("DELETE FROM kazanim_bilgileri WHERE bolum_id = @bolum_id", con);
            cmd2.Parameters.AddWithValue("@bolum_id", bolumid);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            cmd3 = new SqlCommand("DELETE FROM ders_bilgileri WHERE bolum_id = @bolum_id", con);
            cmd3.Parameters.AddWithValue("@bolum_id", bolumid);
            cmd3.ExecuteNonQuery();
            cmd3.Dispose();
            cmd4 = new SqlCommand("DELETE FROM ders_atama_bilgileri WHERE bolum_id = @bolum_id", con);
            cmd4.Parameters.AddWithValue("@bolum_id", bolumid);
            cmd4.ExecuteNonQuery();
            cmd4.Dispose();
            cmd5 = new SqlCommand("DELETE FROM kazanim_bazli_okutma WHERE bolum_id = @bolum_id", con);
            cmd5.Parameters.AddWithValue("@bolum_id", bolumid);
            cmd5.ExecuteNonQuery();
            cmd5.Dispose();
            cmd6 = new SqlCommand("DELETE FROM soru_bazli_okutma WHERE bolum_id = @bolum_id", con);
            cmd6.Parameters.AddWithValue("@bolum_id", bolumid);
            cmd6.ExecuteNonQuery();
            cmd6.Dispose();
            cmd7 = new SqlCommand("DELETE FROM sinav_sonucu_okutma WHERE bolum_id = @bolum_id", con);
            cmd7.Parameters.AddWithValue("@bolum_id", bolumid);
            cmd7.ExecuteNonQuery();
            cmd7.Dispose();

            con.Close();
        }
    }
}