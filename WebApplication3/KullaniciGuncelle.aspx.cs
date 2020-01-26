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
    public partial class KullaniciGuncelle : System.Web.UI.Page
    {
        int id;
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
                DataSet1TableAdapters.kullanici_turTableAdapter dt = new DataSet1TableAdapters.kullanici_turTableAdapter();
                DropDownList1.DataSource = dt.KullaniciTurListele();
                DropDownList1.DataTextField = "kullanici_tur_adi";
                DropDownList1.DataValueField = "kullanici_tur_id";
                DropDownList1.DataBind();
            }
            if (Page.IsPostBack == false) { 
            id = Convert.ToInt32(Request.QueryString["sicil_no"]);
            kul_sicil_no.Text = id.ToString();
            DataSet1TableAdapters.Egitimci_Bilgileri_DbTableAdapter dt2 = new DataSet1TableAdapters.Egitimci_Bilgileri_DbTableAdapter();
            kul_adi.Text = dt2.kullanicisec(id)[0].adi;
            kul_soyadi.Text = dt2.kullanicisec(id)[0].soyadi;
            kul_sifre.Text = dt2.kullanicisec(id)[0].sifre;
            }
        }

        protected void btnkaydet_Click(object sender, EventArgs e)
        {   
            int turid = Convert.ToInt32(DropDownList1.SelectedValue);    
            id = Convert.ToInt32(Request.QueryString["sicil_no"]);
            SqlConnection con;
            SqlCommand cmd;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("UPDATE Egitimci_Bilgileri_Db SET kullanici_tur_id=@tur_id,adi=@kul_adi,soyadi=@kul_soyadi,sifre=@kul_sifre WHERE sicil_no=@kul_sicil_no", con);
            cmd.Parameters.Add("@tur_id", System.Data.SqlDbType.Int);
            cmd.Parameters["@tur_id"].Value = turid;
            cmd.Parameters.Add("@kul_adi", System.Data.SqlDbType.NVarChar,60);
            cmd.Parameters["@kul_adi"].Value = kul_adi.Text;
            cmd.Parameters.Add("@kul_soyadi", System.Data.SqlDbType.NVarChar,60);
            cmd.Parameters["@kul_soyadi"].Value = kul_soyadi.Text;
            cmd.Parameters.Add("@kul_sifre", System.Data.SqlDbType.NVarChar, 60);
            cmd.Parameters["@kul_sifre"].Value = kul_sifre.Text;
            cmd.Parameters.Add("@kul_sicil_no", System.Data.SqlDbType.Int);
            cmd.Parameters["@kul_sicil_no"].Value = id;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
               // lblsoyad.Text = "güncellenmedi";
            }
            finally {con.Close();}
        
            
            
          
        }
    }
}