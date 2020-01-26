using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Data;
namespace WebApplication3
{
    public partial class KazanimBazliDegerlendirme : System.Web.UI.Page
    {   int sili;
        int ust = 15;
        int sol = 5;
        int ilk= 0;
        int[,] sonuc;
        List<string> myList = new List<string>();
        List<string> myList2 = new List<string>();

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["sili"] = sili;
            ViewState["sonuc"] = sonuc;
            ViewState["mylist"] = myList;
            ViewState["mylist2"] = myList2;
        }
          protected void Page_Load(object sender, EventArgs e)
          {
            string kul_sicil_aktif = Session["giriskulsicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin2") as Button;
             if (btn != null)
             {
                
                 btn.Text = "SİCİL NO:"+  " - "+kul_sicil_aktif;
             }
            
            if (Page.IsPostBack)
            {
                sili = (int) ViewState["sili"] ;
                sonuc = (int[,])ViewState["sonuc"];
                myList = (List<string>)ViewState["mylist"];
                myList2 = (List<string>)ViewState["mylist2"];
                dene();
             
            }

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.donem_bilgileriTableAdapter dt2 = new DataSet1TableAdapters.donem_bilgileriTableAdapter();
                drpyil.DataSource = dt2.DonemListele();
                drpyil.DataTextField = "ogretim_yili";
                drpyil.DataValueField = "donem_id";
                drpyil.DataBind();
            }
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.bolum_bilgileriTableAdapter dt2 = new DataSet1TableAdapters.bolum_bilgileriTableAdapter();
                drp_bolum.DataSource = dt2.BolumListele();
                drp_bolum.DataTextField = "bolum_adi";
                drp_bolum.DataValueField = "bolum_id";
                drp_bolum.DataBind();
            }
            if (Page.IsPostBack == false)
            {
                int bolumid = Convert.ToInt32(drp_bolum.SelectedValue);
                DataSet1TableAdapters.ders_bilgileriTableAdapter dt3 = new DataSet1TableAdapters.ders_bilgileriTableAdapter();
                drp_ders.DataSource = dt3.DersListele2(bolumid);
                drp_ders.DataTextField = "ders_adi";
                drp_ders.DataValueField = "ders_kodu";
                drp_ders.DataBind();
            }
            if (Page.IsPostBack == false)
            {
                int derskodu = Convert.ToInt32(drp_ders.SelectedValue);
                SqlConnection con;
                SqlCommand cmd;
                string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
                con = new SqlConnection(constring);
                cmd = new SqlCommand("select ogr_cikti_id,ogrenim_ciktisi from ogrenme_ciktilari where ders_kodu=@derskodu", con);
                cmd.Parameters.AddWithValue("@derskodu", derskodu);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                drp_kazanim.DataSource = dr;
                drp_kazanim.DataTextField = "ogrenim_ciktisi";
                drp_kazanim.DataValueField = "ogr_cikti_id";
                drp_kazanim.DataBind();
                cmd.Dispose();
                dr.Close();
                con.Close();
            }

        }

        public void btnkazanimsecim_Click(object sender, EventArgs e)
        {
           
            string deneme2 = cvpkeygridview.Rows[0].Cells[1].Text.ToString();
            char[] cvpkarakter = deneme2.ToCharArray();
            //lblyariyil.Text = cvpkarakter.Length.ToString();
            DataTable tablo = new DataTable();
            tablo.Columns.Add("Sorular", typeof(string));
            for (int a = 0; a < drp_kazanim.Items.Count; a++)
            {
                tablo.Columns.Add("K " + (a + 1).ToString(), typeof(string));
            }
            for (int f = 0; f < cvpkarakter.Length; f++)
            {
                var dr = tablo.NewRow();
                dr["Sorular"] = "Soru " + (f + 1).ToString();
                for (int c = 0; c < drp_kazanim.Items.Count; c++)
                {
                    TableCell cel = new TableCell();

                    dr["K " + (c + 1).ToString()] = "";
                }

                tablo.Rows.Add(dr);
            }
            sorukazgrid.DataSource = tablo;
            sorukazgrid.DataBind();
            
            for (int j = 0; j < cvpkarakter.Length; j++)
            {
                for (int k = 1; k < drp_kazanim.Items.Count + 1; k++)
                {
                    System.Web.UI.WebControls.CheckBox chk = new System.Web.UI.WebControls.CheckBox();
                    chk.ID = "check" + (j).ToString() + (k).ToString();
                    chk.Checked = false;
                    chk.AutoPostBack = true;
                    sorukazgrid.Rows[j].Cells[k].Controls.Add(chk);
                    //lblbolum.Text = chk.ID.ToString();
                }
            }
           
            sili = cvpkarakter.Length;
            btnkaydet.Enabled = true;
        }

       public void dene()
        {
            for (int j = 0; j < sili; j++)
            {
                for (int k = 1; k < drp_kazanim.Items.Count + 1; k++)
                {
                    System.Web.UI.WebControls.CheckBox chk = new System.Web.UI.WebControls.CheckBox();
                    chk.ID = "check" + (j).ToString() + (k).ToString();
                    chk.Checked = false;
                    chk.AutoPostBack = true;
                    chk.CheckedChanged += new EventHandler(chkdurum);
                    sorukazgrid.Rows[j].Cells[k].Controls.Add(chk);
                   // lblbolum.Text = chk.ID.ToString();
                }
            }
          

        }

        public void chkdurum(object sender, EventArgs e)
        {
            
            CheckBox cek = sender as CheckBox;
         
            if (cek.Checked)
            {
               
                 myList.Add(cek.ID.ToString());
                 //lblbolum.Text = cek.ID.ToString()+"atildi";
                   
            }
             else if(cek.Checked==false)
              {
                // lblbolum.Text = cek.ID.ToString()+"Seçili değil";
                  myList2.Add(cek.ID.ToString());
                  myList.Remove(cek.ID.ToString());
                
            }
        }
        protected void drp_bolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bolumid = Convert.ToInt32(drp_bolum.SelectedValue);
            
            DataSet1TableAdapters.ders_bilgileriTableAdapter dt3 = new DataSet1TableAdapters.ders_bilgileriTableAdapter();
            drp_ders.DataSource = dt3.DersListele2(bolumid);
            drp_ders.DataTextField = "ders_adi";
            drp_ders.DataValueField = "ders_kodu";
            drp_ders.DataBind();

            if (drp_ders.SelectedValue != "") {
            int derskodu = Convert.ToInt32(drp_ders.SelectedValue);
            SqlConnection con;
            SqlCommand cmd;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("select ogr_cikti_id,ogrenim_ciktisi from ogrenme_ciktilari where ders_kodu=@derskodu", con);
            cmd.Parameters.AddWithValue("@derskodu", derskodu);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            drp_kazanim.DataSource = dr;
            drp_kazanim.DataTextField = "ogrenim_ciktisi";
            drp_kazanim.DataValueField = "ogr_cikti_id";
            drp_kazanim.DataBind();
            cmd.Dispose();
            dr.Close();
            con.Close(); 
            }
            else
            {
                drp_kazanim.Items.Clear();
            }
        }

        protected void drp_ders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int derskodu =Convert.ToInt32( drp_ders.SelectedValue);
            SqlConnection con;
            SqlCommand cmd;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("select ogr_cikti_id,ogrenim_ciktisi from ogrenme_ciktilari where ders_kodu=@derskodu", con);
            cmd.Parameters.AddWithValue("@derskodu", derskodu);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            drp_kazanim.DataSource = dr;
            drp_kazanim.DataTextField = "ogrenim_ciktisi";
            drp_kazanim.DataValueField = "ogr_cikti_id";
            drp_kazanim.DataBind();
            cmd.Dispose();
            dr.Close();
            con.Close();
        }

        protected void yukle_Click(object sender, EventArgs e)
        {

            btnkazanimsecim.Enabled = true;
            FileCvpKey.SaveAs(Server.MapPath("cevapanahtari/") + FileCvpKey.FileName);
            string yol3 = (Server.MapPath("cevapanahtari/") + FileCvpKey.FileName).ToString();
            if (File.Exists(yol3))
            {
                
                DataTable dt3 = new DataTable();
                string[] satirlar2 = System.IO.File.ReadAllLines(yol3);
                if (satirlar2.Length > 0)
                {
                    string ilksatir2 = satirlar2[0];
                    string[] basliklar2 = ilksatir2.Split(';');
                    foreach (string baslik2 in basliklar2)
                    {
                        dt3.Columns.Add(new DataColumn(baslik2));
                    }
                    for (int j = 1; j < satirlar2.Length; j++)
                    {
                        string[] veriler2 = satirlar2[j].Split(';');
                        DataRow dr3 = dt3.NewRow();
                        int columnindex = 0;
                        foreach (string veri2 in basliklar2)
                        {
                            dr3[veri2] = veriler2[columnindex++];
                        }
                        dt3.Rows.Add(dr3);
                        
                    }

                }
                if (dt3.Rows.Count > 0)
                {
                    //lblders.Text = "dolu";
                    cvpkeygridview.DataSource = dt3;
                    cvpkeygridview.DataBind();
                }

            }
           

        }

        protected void btnkaydet_Click(object sender, EventArgs e)
        {
            double puani = 100.0 / Convert.ToDouble(sili);
            btneexcel.Enabled = true;
            double[] hesap = new double[drp_kazanim.Items.Count];
            double[] kazanimyuzde = new double[drp_kazanim.Items.Count];
            double[] ortalama = new double[drp_kazanim.Items.Count];
            for (int b = 1; b < drp_kazanim.Items.Count + 1; b++) 
            {
                for (int a = 0; a < sili; a++)
                {
                    string kalip = "check" + a.ToString() + b.ToString();
                    if (myList.Contains(kalip))
                    {
                        hesap[b-1] = hesap[b-1] + puani;
                    }

                }
            }
            for (int d = 0; d < drp_kazanim.Items.Count; d++)
            {

                ortalama[d] =  hesap[d]/sili ;
                kazanimyuzde[d] = (ortalama[d] / Convert.ToDouble(puani))*100.0;

            }
          
            //lblbolum.Text = hesap[0].ToString();

            DataTable tablo = new DataTable();
            tablo.Columns.Add("Kazanım", typeof(string));
            tablo.Columns.Add("Ortalaması", typeof(string));
            tablo.Columns.Add("Başarımı(%)", typeof(string));
           
            for(int c = 0; c < drp_kazanim.Items.Count;c++)
            {
                var dr = tablo.NewRow();
                dr["Kazanım"] = "K" + (c + 1).ToString();
                dr["Ortalaması"] = ortalama[c].ToString("0.##");
                dr["Başarımı(%)"] = kazanimyuzde[c].ToString("0.##");
                tablo.Rows.Add(dr);
            }
            sonucgrid.DataSource = tablo;
            sonucgrid.DataBind();

           

        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void btneexcel_Click(object sender, EventArgs e)
        {
            
            string dosyaadi =  drpyil.SelectedItem.Text+"_"+ drp_donem.SelectedItem.Text +"_"+ drp_yariyil.SelectedItem.Text+"_"+drp_sinavtur.SelectedItem.Text+"_"+drp_bolum.SelectedItem.Text+"_"+drp_ders.SelectedItem.Text+"_"+"Kazanim_Bazli_Degerlendirme.xls";
            string kayit_dosya_adi= "attachement;filename="+dosyaadi;
            Response.ClearContent();
            Response.AppendHeader("content-disposition",kayit_dosya_adi );
            Response.ContentType = "application/excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter ht = new HtmlTextWriter(sw);
            sonucgrid.RenderControl(ht);
            Response.Write(sw.ToString());
            Response.End();
            fileexcel.Enabled = true;
            btnsistemkayit.Enabled = true;
        }

        protected void btnsistemkayit_Click(object sender, EventArgs e)
        {
            string kul_sicil_aktif = Session["giriskulsicil"].ToString();
           fileexcel.SaveAs(Server.MapPath("kazanimsonuc/") + fileexcel.FileName);
           string uzanti = (Server.MapPath("kazanimsonuc/") + fileexcel.FileName).ToString();
           if (File.Exists(uzanti))
            {
                string filepathi = uzanti.Substring(uzanti.LastIndexOf('\\')+1);
                 DataSet1TableAdapters.kazanim_bazli_okutmaTableAdapter dt = new DataSet1TableAdapters.kazanim_bazli_okutmaTableAdapter();
                 dt.kazokutyaz(Convert.ToInt32(drp_bolum.SelectedValue), Convert.ToInt32(drp_ders.SelectedValue), Convert.ToInt32(drpyil.SelectedValue), drp_sinavtur.SelectedItem.Text, drp_yariyil.SelectedItem.Text, Convert.ToInt32(kul_sicil_aktif),filepathi);
                
            }
            //lblbolum.Text = drp_bolum.SelectedValue.ToString() + drp_ders.SelectedValue.ToString();

        }
    }
}