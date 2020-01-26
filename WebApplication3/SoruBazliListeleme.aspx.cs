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
    public partial class SoruBazliListeleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string kul_sicil_aktif = Session["giriskulsicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin2") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + kul_sicil_aktif;
            }
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.donem_bilgileriTableAdapter dt2 = new DataSet1TableAdapters.donem_bilgileriTableAdapter();
                drp_donem.DataSource = dt2.DonemListele();
                drp_donem.DataTextField = "ogretim_yili";
                drp_donem.DataValueField = "donem_id";
                drp_donem.DataBind();
            }
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.bolum_bilgileriTableAdapter dt2 = new DataSet1TableAdapters.bolum_bilgileriTableAdapter();
                drpbolum.DataSource = dt2.BolumListele();
                drpbolum.DataTextField = "bolum_adi";
                drpbolum.DataValueField = "bolum_id";
                drpbolum.DataBind();
            }
        }

        protected void btngetir_Click(object sender, EventArgs e)
        {
            lblbaslik.Text = drpbolum.SelectedItem.ToString() + " > " + drp_donem.SelectedItem.ToString() + " > " + drpyariyil.SelectedItem.ToString();
            string kul_sicil_aktif = Session["giriskulsicil"].ToString();
            SqlConnection con;
            SqlCommand cmd, cmd2, cmd3;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("select d.ders_adi ,s.kazanim_path from ders_bilgileri d,soru_bazli_okutma s  where s.donem_id=@getdonem and s.bolum_id=@getbolumid and s.yariyil=@getyariyil and s.sicil_no=@getsicil and s.ders_kodu=d.ders_kodu and s.sınav_turu='Vize' ", con);
            cmd.Parameters.AddWithValue("@getdonem", Convert.ToInt32(drp_donem.SelectedValue));
            cmd.Parameters.AddWithValue("@getbolumid", Convert.ToInt32(drpbolum.SelectedValue));
            cmd.Parameters.AddWithValue("@getyariyil", drpyariyil.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@getsicil", Convert.ToInt32(kul_sicil_aktif));
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Repeater1.DataSource = reader;
            Repeater1.DataBind();
            reader.Close();
            cmd.Dispose();

            cmd2 = new SqlCommand("select d.ders_adi ,s.kazanim_path from ders_bilgileri d,soru_bazli_okutma s  where s.donem_id=@getdonem and s.bolum_id=@getbolumid and s.yariyil=@getyariyil and s.sicil_no=@getsicil and s.ders_kodu=d.ders_kodu and s.sınav_turu='Final' ", con);
            cmd2.Parameters.AddWithValue("@getdonem", Convert.ToInt32(drp_donem.SelectedValue));
            cmd2.Parameters.AddWithValue("@getbolumid", Convert.ToInt32(drpbolum.SelectedValue));
            cmd2.Parameters.AddWithValue("@getyariyil", drpyariyil.SelectedItem.Text);
            cmd2.Parameters.AddWithValue("@getsicil", Convert.ToInt32(kul_sicil_aktif));
            SqlDataReader reader2 = cmd2.ExecuteReader();
            Repeater2.DataSource = reader2;
            Repeater2.DataBind();
            reader2.Close();
            cmd2.Dispose();

            cmd3 = new SqlCommand("select d.ders_adi ,s.kazanim_path from ders_bilgileri d,soru_bazli_okutma s  where s.donem_id=@getdonem and s.bolum_id=@getbolumid and s.yariyil=@getyariyil and s.sicil_no=@getsicil and s.ders_kodu=d.ders_kodu and s.sınav_turu='Bütünleme' ", con);
            cmd3.Parameters.AddWithValue("@getdonem", Convert.ToInt32(drp_donem.SelectedValue));
            cmd3.Parameters.AddWithValue("@getbolumid", Convert.ToInt32(drpbolum.SelectedValue));
            cmd3.Parameters.AddWithValue("@getyariyil", drpyariyil.SelectedItem.Text);
            cmd3.Parameters.AddWithValue("@getsicil", Convert.ToInt32(kul_sicil_aktif));
            SqlDataReader reader3 = cmd3.ExecuteReader();
            Repeater3.DataSource = reader3;
            Repeater3.DataBind();
            reader3.Close();
            cmd3.Dispose();
            con.Close();
        }
    }
}