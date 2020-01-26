using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class DersEkleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelen = Session["girissicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + gelen;
            }
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.bolum_bilgileriTableAdapter dt = new DataSet1TableAdapters.bolum_bilgileriTableAdapter();
                drpbolumlistesi.DataSource = dt.BolumListele();
                drpbolumlistesi.DataTextField = "bolum_adi";
                drpbolumlistesi.DataValueField = "bolum_id";
                drpbolumlistesi.DataBind();
            }
            if(Page.IsPostBack==false)
            { 
            DataSet1TableAdapters.donem_bilgileriTableAdapter dt2 = new DataSet1TableAdapters.donem_bilgileriTableAdapter();
            drp_donem.DataSource = dt2.DonemListele();
            drp_donem.DataTextField = "ogretim_yili";
            drp_donem.DataValueField = "donem_id";
            drp_donem.DataBind();
            }
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.ders_bilgileriTableAdapter dt4 = new DataSet1TableAdapters.ders_bilgileriTableAdapter();
                drpdersliste.DataSource = dt4.DersListele();
                drpdersliste.DataTextField = "ders_adi";
                drpdersliste.DataValueField = "ders_kodu";
                drpdersliste.DataBind();
            }

        }

        protected void btnciktiekle_Click(object sender, EventArgs e)
        {
            int selectderskodu = Convert.ToInt32(drpdersliste.SelectedValue);
            string[] ders_ciktilar = new string[10];
            string cikti_adi = txtcikti.Text.ToString();
            ListBox1.Items.Add(cikti_adi);
            for (int j = 0; j < ListBox1.Items.Count; j++)
            {
                ders_ciktilar[j] = ListBox1.Items[j].Text.ToString();
            }

            DataSet1TableAdapters.ogrenme_ciktilariTableAdapter dt5 = new DataSet1TableAdapters.ogrenme_ciktilariTableAdapter();
            dt5.OgrenmeCiktisiInsert(selectderskodu,txtcikti.Text);
            txtcikti.Text = "";
        }

        protected void btnkaydet_ders_Click(object sender, EventArgs e)
        {
            int derskodu = Convert.ToInt32(txtderskodu.Text.ToString());
            int bolumid = Convert.ToInt32(drpbolumlistesi.SelectedValue);
            int donemid = Convert.ToInt32(drp_donem.SelectedValue);
            DataSet1TableAdapters.ders_bilgileriTableAdapter dt3 = new DataSet1TableAdapters.ders_bilgileriTableAdapter();
            dt3.DersInsert(derskodu, txtDers.Text, drp_yariyil.Text, donemid, bolumid);
            Response.Redirect("DersEkleme.Aspx");
        }

        protected void drpdersliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int bolumid = Convert.ToInt32(drpbolumlistesi.SelectedValue);
            DataSet1TableAdapters.ders_bilgileriTableAdapter dt5 = new DataSet1TableAdapters.ders_bilgileriTableAdapter();
            drpdersliste.DataSource = dt5.DersListele2(bolumid);
            drpdersliste.DataTextField = "ders_adi";
            drpdersliste.DataValueField = "ders_kodu";
            drpdersliste.DataBind();
         

        }
    }
}