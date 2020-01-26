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
    public partial class DersGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelen = Session["girissicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + gelen;
            }
            if (Page.IsPostBack == false) { 
            dersadi.Text = Request.QueryString["dersadi"].ToString();
            derskodu.Text = Request.QueryString["derskodu"].ToString();
            ogrciktiid.Text = Request.QueryString["ogrciktiid"].ToString();
            ogrenmecikti.Text = Request.QueryString["ogrcikti"].ToString();}
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.bolum_bilgileriTableAdapter dt = new DataSet1TableAdapters.bolum_bilgileriTableAdapter();
                drpbolum.DataSource = dt.BolumListele();
                drpbolum.DataTextField = "bolum_adi";
                drpbolum.DataValueField = "bolum_id";
                drpbolum.DataBind();
                for (int i = 0; i < drpbolum.Items.Count; i++)
                {
                    string bolumadi = Request.QueryString["bolumadi"].ToString();
                    if (drpbolum.Items[i].Text == bolumadi)
                    {

                        drpbolum.Items.FindByValue(drpbolum.Items[i].Value).Selected = true;
                        break;
                    }
                }
            }
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.donem_bilgileriTableAdapter dt = new DataSet1TableAdapters.donem_bilgileriTableAdapter();
                drpogretimyili.DataSource = dt.DonemListele();
               drpogretimyili.DataTextField = "ogretim_yili";
               drpogretimyili.DataValueField = "donem_id";
                drpogretimyili.DataBind();
                for (int i = 0; i < drpogretimyili.Items.Count; i++)
                {
                    string drpyil = Request.QueryString["ogretimyili"].ToString();
                    if (drpogretimyili.Items[i].Text ==drpyil)
                    {

                        drpogretimyili.Items.FindByValue(drpogretimyili.Items[i].Value).Selected = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < drpyariyil.Items.Count; i++)
            {
                string yariyil = Request.QueryString["yariyil"].ToString();
                if (drpyariyil.Items[i].Text == yariyil)
                {

                    drpyariyil.Items.FindByValue(drpyariyil.Items[i].Value).Selected = true;
                    break;
                }
            }

        }

        protected void btnkaydet_Click(object sender, EventArgs e)
        {
            int derskod = Convert.ToInt32(Request.QueryString["derskodu"].ToString());
            int ciktiid = Convert.ToInt32(Request.QueryString["ogrciktiid"].ToString());
            SqlConnection con;
            SqlCommand cmd,cmd2;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("update ders_bilgileri set ders_adi=@ders_adi,yariyil=@yariyil,donem_id=@donem_id,bolum_id=@bolum_id where ders_kodu=@derskodu", con);
            cmd.Parameters.AddWithValue("@ders_adi",dersadi.Text.ToString());
            cmd.Parameters.AddWithValue("@yariyil",drpyariyil.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@donem_id",Convert.ToInt32(drpogretimyili.SelectedValue));
            cmd.Parameters.AddWithValue("@bolum_id",Convert.ToInt32(drpbolum.SelectedValue));
            cmd.Parameters.AddWithValue("@derskodu",derskod);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd2 = new SqlCommand("update ogrenme_ciktilari set ogrenim_ciktisi=@ogrcikti where ders_kodu=@derskodu and ogr_cikti_id=@ogrciktiid", con);
            cmd2.Parameters.AddWithValue("@ogrcikti", ogrenmecikti.Text.ToString());
            cmd2.Parameters.AddWithValue("@derskodu", derskod);
            cmd2.Parameters.AddWithValue("@ogrciktiid",ciktiid);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            con.Close();

        }
    }
}