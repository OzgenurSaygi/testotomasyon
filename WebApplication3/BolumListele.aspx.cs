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
    public partial class BolumListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelen = Session["girissicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + gelen;
            }
            DataSet1TableAdapters.bolkazlist1TableAdapter dt2 = new DataSet1TableAdapters.bolkazlist1TableAdapter();
            Repeater2.DataSource = dt2.bolum_kazanim_liste();
            Repeater2.DataBind();
           
           
        }

        protected void btnara_Click(object sender, EventArgs e)
        {
            string bolumadi=bolara.Text;
            SqlConnection con;
            SqlCommand cmd;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("select b.bolum_id,f.fakulte_adi,b.bolum_adi,k.kazanim_id,k.kazanim_adi from bolum_bilgileri b,fakulte_bilgileri f,kazanim_bilgileri k where b.bolum_id=(select bolum_id from bolum_bilgileri where bolum_adi=@bolumadi) and f.fakulte_id=b.fakulte_id and b.bolum_id=k.bolum_id ;", con);
            cmd.Parameters.AddWithValue("@bolumadi", bolumadi);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Repeater2.DataSource = reader;
            Repeater2.DataBind();
            reader.Close();
            con.Close();
        }
    }
}