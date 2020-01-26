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
    public partial class DersAtamalariListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelen = Session["girissicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + gelen;
            }
          
            DataSet1TableAdapters.dersatamaliste1TableAdapter dt = new DataSet1TableAdapters.dersatamaliste1TableAdapter();
            Repeater1.DataSource = dt.DersAtamaPro();
            Repeater1.DataBind();
        }

        protected void drpsecim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnara_Click(object sender, EventArgs e)
        {
            if (dersatamaara.Text != "") { 
            int sicilno = Convert.ToInt32(dersatamaara.Text);
            SqlConnection con;
            SqlCommand cmd;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("select d.ders_atama_id,e.sicil_no,e.adi,b.bolum_adi,s.ders_adi,d.yariyil,k.ogretim_yili from ders_atama_bilgileri d,Egitimci_Bilgileri_Db e,bolum_bilgileri b,ders_bilgileri s,donem_bilgileri k where e.sicil_no=@sicilno and e.sicil_no=d.sicil_no  and s.ders_kodu=d.ders_kodu  and k.donem_id=d.donem_id and b.bolum_id=d.bolum_id;", con);
            cmd.Parameters.AddWithValue("@sicilno", sicilno);
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