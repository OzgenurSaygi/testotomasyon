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
    public partial class DersAtaGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelen = Session["girissicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + gelen;
            }
            txtsicil.Text = Request.QueryString["sicilno"].ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.donem_bilgileriTableAdapter dt = new DataSet1TableAdapters.donem_bilgileriTableAdapter();
                drpdonem.DataSource = dt.DonemListele();
                drpdonem.DataTextField = "ogretim_yili";
                drpdonem.DataValueField = "donem_id";
                drpdonem.DataBind();
                for (int i = 0; i < drpdonem.Items.Count; i++)
                {
                    string drpyil = Request.QueryString["ogretimyili"].ToString();
                    if (drpdonem.Items[i].Text == drpyil)
                    {

                        drpdonem.Items.FindByValue(drpdonem.Items[i].Value).Selected = true;
                        break;
                    }
                }
            }

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
                SqlConnection con;
                SqlCommand cmd;
                string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
                con = new SqlConnection(constring);
                cmd = new SqlCommand("select*from ders_bilgileri where bolum_id=@getbolid", con);
                cmd.Parameters.AddWithValue("@getbolid", drpbolum.SelectedValue);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                drpders.DataSource = dr;
                drpders.DataTextField = "ders_adi";
                drpders.DataValueField = "ders_kodu";
                drpders.DataBind();
                dr.Close();
                con.Close();
                for (int i = 0; i < drpders.Items.Count; i++)
                {
                    string dersadi = Request.QueryString["dersadi"].ToString();
                    if (drpders.Items[i].Text == dersadi)
                    {

                        drpders.Items.FindByValue(drpders.Items[i].Value).Selected = true;
                        break;
                    }
                }
            }
            if (Page.IsPostBack == false)
            {
                SqlConnection con;
                SqlCommand cmd;
                string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
                con = new SqlConnection(constring);
                cmd = new SqlCommand("select*from Egitimci_Bilgileri_Db", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                drpad.DataSource = dr;
                drpad.DataTextField = "adi";
                drpad.DataValueField = "sicil_no";
                drpad.DataBind();
                dr.Close();
                con.Close();
                for (int i = 0; i < drpad.Items.Count; i++)
                {
                    string kadi = Request.QueryString["adi"].ToString();
                    if (drpad.Items[i].Text == kadi)
                    {

                        drpad.Items.FindByValue(drpad.Items[i].Value).Selected = true;
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
        

        protected void drpbolum_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection con;
            SqlCommand cmd;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("select*from ders_bilgileri where bolum_id=@getbolid", con);
            cmd.Parameters.AddWithValue("@getbolid", drpbolum.SelectedValue);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            drpders.DataSource = dr;
            drpders.DataTextField = "ders_adi";
            drpders.DataValueField = "ders_kodu";
            drpders.DataBind();
            dr.Close();
            con.Close();

        }

        protected void btnkaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["dersataid"].ToString());
            SqlConnection con;
            SqlCommand cmd;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("update ders_atama_bilgileri set bolum_id=@getbolid,ders_kodu=@getderskodu,yariyil=@getyariyil,donem_id=@getdonemid,sicil_no=@getsicilno where ders_atama_id=@getid",con);
            cmd.Parameters.AddWithValue("@getbolid", Convert.ToInt32(drpbolum.SelectedValue));
            cmd.Parameters.AddWithValue("@getderskodu",Convert.ToInt32 (drpders.SelectedValue));
            cmd.Parameters.AddWithValue("@getyariyil", drpyariyil.SelectedValue);
            cmd.Parameters.AddWithValue("@getdonemid", Convert.ToInt32(drpdonem.SelectedValue));
            cmd.Parameters.AddWithValue("@getsicilno",Convert.ToInt32(drpad.SelectedValue) );
            cmd.Parameters.AddWithValue("@getid",id);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
         
        }
    }
}