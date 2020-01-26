using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
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
            DataSet1TableAdapters.kullanici_turTableAdapter dt = new DataSet1TableAdapters.kullanici_turTableAdapter();
            DropDownList1.DataSource = dt.KullaniciTurListele();
            DropDownList1.DataTextField = "kullanici_tur_adi";
            DropDownList1.DataValueField = "kullanici_tur_id";
            DropDownList1.DataBind();}
        }

        protected void btnkaydet_Click(object sender, EventArgs e)
        {
          
            int id =Convert.ToInt32( DropDownList1.SelectedValue);
            int sicil_no = Convert.ToInt32(kul_sicil_no.Text);
            DataSet1TableAdapters.Egitimci_Bilgileri_DbTableAdapter dt = new DataSet1TableAdapters.Egitimci_Bilgileri_DbTableAdapter();
            dt.InsertKullanici(sicil_no,id, kul_adi.Text, kul_soyadi.Text, kul_sifre.Text);
            Response.Redirect("WebForm1.Aspx");
         
        }
    }
}