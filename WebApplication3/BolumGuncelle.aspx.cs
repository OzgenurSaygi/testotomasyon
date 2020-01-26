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
    public partial class BolumGuncelle : System.Web.UI.Page
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
                drpfakulte.DataSource = dt.FakulteListele();
                drpfakulte.DataTextField = "fakulte_adi";
                drpfakulte.DataValueField = "fakulte_id";
                drpfakulte.DataBind();
            }

        

            if (Page.IsPostBack == false)
            {
                int bolumid = Convert.ToInt32(Request.QueryString["bolum_id"]);
                int kazanimid = Convert.ToInt32(Request.QueryString["kazanim_id"]);
                SqlConnection con;
                SqlCommand cmd,cmd2;
                string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
                con = new SqlConnection(constring);
                cmd = new SqlCommand("select*from bolum_bilgileri where bolum_id=@GetBolumID",con);
                cmd.Parameters.AddWithValue("@GetBolumID", bolumid);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    bolum_id.Text = dr["bolum_id"].ToString();
                    bol_ad.Text = dr["bolum_adi"].ToString();
                }
                dr.Close();
                cmd2= new SqlCommand("select*from kazanim_bilgileri where bolum_id=@GetBolumID and kazanim_id=@GetKazID", con);
                cmd2.Parameters.AddWithValue("@GetBolumID", bolumid);
                cmd2.Parameters.AddWithValue("@GetKazID",kazanimid);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                   TextBox1.Text = dr2["kazanim_id"].ToString();
                   kazanım.Text = dr2["kazanim_adi"].ToString();
                }
                dr2.Close();
                con.Close();
            }
        }

        protected void btnkaydet_Click(object sender, EventArgs e)
        {
            int bolumid = Convert.ToInt32(bolum_id.Text);
            int kazid = Convert.ToInt32(TextBox1.Text);
            SqlConnection con;
            SqlCommand cmd,cmd2;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("UPDATE bolum_bilgileri SET bolum_adi=@getbolumadi,fakulte_id=@getfakid where bolum_id=@getbolumid",con);
            cmd.Parameters.Add("@getbolumadi", System.Data.SqlDbType.NVarChar,60);
            cmd.Parameters["@getbolumadi"].Value =bol_ad.Text;
            cmd.Parameters.Add("@getfakid", System.Data.SqlDbType.Int);
            cmd.Parameters["@getfakid"].Value =Convert.ToInt32(drpfakulte.SelectedValue);
            cmd.Parameters.Add("@getbolumid", System.Data.SqlDbType.Int);
            cmd.Parameters["@getbolumid"].Value = bolumid;
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd2 = new SqlCommand("UPDATE kazanim_bilgileri SET kazanim_adi=@getkazadi where bolum_id=@getbolumid and kazanim_id=@getkazid", con);
            cmd2.Parameters.Add("@getkazadi", System.Data.SqlDbType.VarChar, 150);
            cmd2.Parameters["@getkazadi"].Value = kazanım.Text;
            cmd2.Parameters.Add("@getbolumid", System.Data.SqlDbType.Int);
            cmd2.Parameters["@getbolumid"].Value = bolumid;
            cmd2.Parameters.Add("@getkazid", System.Data.SqlDbType.Int);
            cmd2.Parameters["@getkazid"].Value = kazid;
            cmd2.ExecuteNonQuery();
            con.Close();


        }
    }
}