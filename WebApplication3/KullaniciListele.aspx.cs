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
    public partial class KullaniciListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelen = Session["girissicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + gelen;
            }
            DataSet1TableAdapters.kullanicilistesiTableAdapter dt = new DataSet1TableAdapters.kullanicilistesiTableAdapter();
            Repeater1.DataSource = dt.KullaniciListesi();
            Repeater1.DataBind();
        }

        protected void btnara_Click(object sender, EventArgs e)
        {
            if (kulara.Text != "") { 
            int sicil = Convert.ToInt32(kulara.Text);
            SqlConnection con;
            SqlCommand cmd;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("select k.sicil_no,k.adi,k.soyadi,k.sifre,t.kullanici_tur_adi from Egitimci_Bilgileri_Db k,kullanici_tur t where k.sicil_no=@sicil and k.kullanici_tur_id=t.kullanici_tur_id",con);
            cmd.Parameters.AddWithValue("@sicil", sicil);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Repeater1.DataSource = reader;
            Repeater1.DataBind();
            reader.Close();
            con.Close();
            }
        }
    }
}