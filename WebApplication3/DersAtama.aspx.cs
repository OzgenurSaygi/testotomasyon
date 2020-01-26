using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class DersAtama : System.Web.UI.Page
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
                DataSet1TableAdapters.donem_bilgileriTableAdapter dt = new DataSet1TableAdapters.donem_bilgileriTableAdapter();
                drp_donem.DataSource = dt.DonemListele();
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
            if (Page.IsPostBack == false)
            {
                int bolumid = Convert.ToInt32(drpbolum.SelectedValue);
                DataSet1TableAdapters.ders_bilgileriTableAdapter dt3 = new DataSet1TableAdapters.ders_bilgileriTableAdapter();
                drpdersliste.DataSource = dt3.DersListele2(bolumid);
                drpdersliste.DataTextField = "ders_adi";
                drpdersliste.DataValueField = "ders_kodu";
                drpdersliste.DataBind();
            }


        }

        protected void drpbolum_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            int bolumid = Convert.ToInt32(drpbolum.SelectedValue);
            DataSet1TableAdapters.ders_bilgileriTableAdapter dt3 = new DataSet1TableAdapters.ders_bilgileriTableAdapter();
            drpdersliste.DataSource = dt3.DersListele2(bolumid);
            drpdersliste.DataTextField = "ders_adi";
            drpdersliste.DataValueField = "ders_kodu";
            drpdersliste.DataBind(); 
         
        }

        protected void btnkaydet_ders_Click(object sender, EventArgs e)
        {
            int bolumid = Convert.ToInt32(drpbolum.SelectedValue);
            int donemid = Convert.ToInt32(drp_donem.SelectedValue);
            int derskodu = Convert.ToInt32(drpdersliste.SelectedValue);
            int sicil = Convert.ToInt32(txtSicil.Text);
            DataSet1TableAdapters.ders_atama_bilgileriTableAdapter dt4 = new DataSet1TableAdapters.ders_atama_bilgileriTableAdapter();
            dt4.DersAtamaInsert(bolumid,derskodu,drpyariyil.Text,donemid,sicil);
            Response.Redirect("DersAtama.Aspx");
        }
    }
}