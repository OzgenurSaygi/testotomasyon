using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class BolumEkleme : System.Web.UI.Page
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
                DataSet1TableAdapters.fakulte_bilgileriTableAdapter dt = new DataSet1TableAdapters.fakulte_bilgileriTableAdapter();
                drpfakulteliste.DataSource = dt.FakulteListele();
                drpfakulteliste.DataTextField = "fakulte_adi";
                drpfakulteliste.DataValueField = "fakulte_id";
                drpfakulteliste.DataBind();
            }
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.bolum_bilgileriTableAdapter dt = new DataSet1TableAdapters.bolum_bilgileriTableAdapter();
                drpbolumliste.DataSource = dt.BolumListele();
                drpbolumliste.DataTextField = "bolum_adi";
                drpbolumliste.DataValueField = "bolum_id";
                drpbolumliste.DataBind();
            }
        }
        
        protected void btnkazanimekle_Click(object sender, EventArgs e)
        {
            int bolumid = Convert.ToInt32(drpbolumliste.SelectedValue);
            string[] kazanimlar = new string[10];
            string kazanim_adi = txtkazanim.Text.ToString();
            ListBox1.Items.Add(kazanim_adi);
           for(int j = 0; j < ListBox1.Items.Count; j++)
            {
                kazanimlar[j] = ListBox1.Items[j].Text.ToString();
            }
            DataSet1TableAdapters.kazanim_bilgileriTableAdapter dt = new DataSet1TableAdapters.kazanim_bilgileriTableAdapter();
            dt.KazanimInsert(kazanim_adi, bolumid);
           
        }

        protected void btnkaydet_blm_Click(object sender, EventArgs e)
        {
            int fakulteid = Convert.ToInt32(drpfakulteliste.SelectedValue);
            DataSet1TableAdapters.bolum_bilgileriTableAdapter dt = new DataSet1TableAdapters.bolum_bilgileriTableAdapter();
            dt.BolumInsert(fakulteid, txtbolumadi.Text);
            Response.Redirect("BolumEkleme.Aspx");
            


        }
    }
}