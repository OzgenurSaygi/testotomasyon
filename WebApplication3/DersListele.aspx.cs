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
    public partial class DersListele : System.Web.UI.Page
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
                DataSet1TableAdapters.dersogrciktilistTableAdapter dt2 = new DataSet1TableAdapters.dersogrciktilistTableAdapter();
                Repeater1.DataSource = dt2.dersogrlist();
                Repeater1.DataBind();
            }
        }

        protected void btnara_Click(object sender, EventArgs e)
        {
            string bolumadi = derslisteara.Text;
            SqlConnection con;
            SqlCommand cmd;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("select d.ders_kodu,b.bolum_adi,k.ogretim_yili,d.yariyil,d.ders_adi,o.ogr_cikti_id,o.ogrenim_ciktisi from ders_bilgileri d,bolum_bilgileri b,donem_bilgileri k,ogrenme_ciktilari o where d.bolum_id=(select bolum_id from bolum_bilgileri where bolum_adi=@bolumadi) and d.bolum_id=b.bolum_id  and k.donem_id=d.donem_id and d.ders_kodu=o.ders_kodu", con);
            cmd.Parameters.AddWithValue("@bolumadi", bolumadi);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Repeater1.DataSource = reader;
            Repeater1.DataBind();
            reader.Close();
            con.Close();
        }

    }
}