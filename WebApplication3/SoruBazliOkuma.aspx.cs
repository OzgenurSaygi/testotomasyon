using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
namespace WebApplication3
{
    
    public partial class SoruBazliOkuma : System.Web.UI.Page
    {
        string[] isimler;
        string[] soyadlar;
        string[] gruplar;
        string[] numaralar;
        string[] verilencvp;
        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["isimler"] = isimler;
            ViewState["soyadlar"] = soyadlar;
            ViewState["gruplar"] = gruplar;
            ViewState["numaralar"] = numaralar;
            ViewState["verilencvp"] = verilencvp;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string kul_sicil_aktif = Session["giriskulsicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin2") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + kul_sicil_aktif;
            }

            if (Page.IsPostBack)
            {

                isimler = (string[])ViewState["isimler"];
                soyadlar = (string[])ViewState["soyadlar"];
                gruplar = (string[])ViewState["gruplar"];
                numaralar = (string[])ViewState["numaralar"];
                verilencvp = (string[])ViewState["verilencvp"];
              

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
                DataSet1TableAdapters.donem_bilgileriTableAdapter dt2 = new DataSet1TableAdapters.donem_bilgileriTableAdapter();
                drpyil.DataSource = dt2.DonemListele();
                drpyil.DataTextField = "ogretim_yili";
                drpyil.DataValueField = "donem_id";
                drpyil.DataBind();
            }
        }

        protected void yukle_Click(object sender, EventArgs e)
        {
            
            string deger = FileVeriler.FileName.ToString();
            // string yol = "C:" + deger;
            int i = 0;
            FileVeriler.SaveAs(Server.MapPath("cevaplarim/") + FileVeriler.FileName);
            string yol2 = (Server.MapPath("cevaplarim/") + FileVeriler.FileName).ToString();
            if (File.Exists(yol2))
            {
               // lblders.Text = "başrılı";
                DataTable dt2 = new DataTable();
                string[] satirlar = System.IO.File.ReadAllLines(yol2);
                if (satirlar.Length > 0)
                {
                    string ilksatir = satirlar[0];
                    string[] basliklar = ilksatir.Split(';');
                    foreach (string baslik in basliklar)
                    {
                        dt2.Columns.Add(new DataColumn(baslik));
                    }
                    for (int j = 1; j < satirlar.Length; j++)
                    {
                        string[] veriler = satirlar[j].Split(';');
                        DataRow dr = dt2.NewRow();
                        int columnindex = 0;
                        foreach (string veri in basliklar)
                        {
                            dr[veri] = veriler[columnindex++];
                        }
                        dt2.Rows.Add(dr);
                    }
                }
                if (dt2.Rows.Count > 0)
                {
                    cvpgridview.DataSource = dt2;
                    cvpgridview.DataBind();
                    

                }

                  isimler = new string[cvpgridview.Rows.Count];
                  soyadlar = new string[cvpgridview.Rows.Count];
                  gruplar = new string[cvpgridview.Rows.Count];
                  numaralar = new string[cvpgridview.Rows.Count];
                  verilencvp = new string[cvpgridview.Rows.Count];
                for (int b = 0; b < cvpgridview.Rows.Count; b++)
                {

                    isimler[b] = cvpgridview.Rows[b].Cells[1].Text.TrimEnd().TrimStart().ToString();
                    soyadlar[b] = cvpgridview.Rows[b].Cells[2].Text.TrimEnd().TrimStart().ToString();
                    numaralar[b] = cvpgridview.Rows[b].Cells[3].Text.TrimEnd().TrimStart().ToString();
                    gruplar[b] = cvpgridview.Rows[b].Cells[4].Text.TrimEnd().TrimStart().ToString();
                    verilencvp[b] = cvpgridview.Rows[b].Cells[5].Text.ToString();

                }

                for (int a = 0; a < numaralar.Length; a++)
                {
                    char[] numara = numaralar[a].ToCharArray();
                    
                    if (numaralar[a] == "")
                    {
                        cvpgridview.Rows[a].Cells[3].Text = "Numara yok";
                        cvpgridview.Rows[a].Cells[3].BackColor = System.Drawing.Color.Red;
                        continue;
                    }
                    if(numara.Length != 9)
                    {
                        cvpgridview.Rows[a].Cells[3].Text = cvpgridview.Rows[a].Cells[3].Text+ "Numara az";
                        cvpgridview.Rows[a].Cells[3].BackColor = System.Drawing.Color.Red;
                    }

                }
                for(int b = 0; b < gruplar.Length; b++)
                {
                    if (gruplar[b] == "")
                    {
                        cvpgridview.Rows[b].Cells[4].Text = "Grup Yok";
                        cvpgridview.Rows[b].Cells[4].BackColor = System.Drawing.Color.Red;
                    }
                }
                for (int c = 0; c< isimler.Length; c++)
                {
                    if (isimler[c] == "")
                    {
                        cvpgridview.Rows[c].Cells[1].Text = "İsim Yok";
                        cvpgridview.Rows[c].Cells[1].BackColor = System.Drawing.Color.Red;
                    }
                }
                for (int d = 0; d< soyadlar.Length; d++)
                {
                    if (soyadlar[d] == "")
                    {
                        cvpgridview.Rows[d].Cells[2].Text = "Soyad Yok";
                        cvpgridview.Rows[d].Cells[2].BackColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        protected void yukle2_Click(object sender, EventArgs e)
        {
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
                    //lblyariyil.Text = "dolu";
                    cvpkeygridview.DataSource = dt3;
                    cvpkeygridview.DataBind();
                   
                }
                

             }
        }

        protected void btndegerlendir_Click(object sender, EventArgs e)
        {
            string deneme2 = "";
            string deger = FileCvpKey.FileName.ToString();
           // deneme2 = cvpgridview.Rows[5].Cells[5].Text.ToString();
            string keyscvp = "";
            keyscvp = cvpkeygridview.Rows[0].Cells[1].Text.ToString();
            char[] keykarakter = keyscvp.ToCharArray();

            //char[] cvpkaraktersayi = deneme2.ToCharArray();
            char[,] cevaplar = new char[cvpgridview.Rows.Count, keykarakter.Length];

            for (int a = 0; a < cvpgridview.Rows.Count; a++)
            {
                deneme2 = cvpgridview.Rows[a].Cells[5].Text.ToString();
                char[] cvpkarakter = deneme2.ToCharArray();
                for (int d = 0; d < cvpkarakter.Length; d++)
                {
                    cevaplar[a, d] = cvpkarakter[d];
                }

            }

            string[] cvpkeygrup = new string[cvpkeygridview.Rows.Count];
            char[,] anahatar = new char[cvpkeygrup.Length, keykarakter.Length];

            for (int k = 0; k < cvpkeygridview.Rows.Count; k++)
            {
                cvpkeygrup[k] = cvpkeygridview.Rows[k].Cells[0].Text.ToString();

            }
            for (int m = 0; m < cvpkeygrup.Length; m++)
            {
                keyscvp = cvpkeygridview.Rows[m].Cells[1].Text.ToString();
                keykarakter = keyscvp.ToCharArray();
                for (int l = 0; l < keykarakter.Length; l++)
                {
                    anahatar[m, l] = keykarakter[l];
                }
            }
           
            double puan = 0.0;
            double[] puanlar = new double[cvpgridview.Rows.Count];
            double[,] sonuclar = new double[cvpgridview.Rows.Count, keykarakter.Length];
            for (int h = 0; h < cvpgridview.Rows.Count; h++)
            {
                for (int j = 0; j < cvpkeygrup.Length; j++)
                {
                    if (gruplar[h] == cvpkeygrup[j])
                    {
                        for (int s = 0; s < keykarakter.Length; s++)
                        {
                            if (cevaplar[h, s] == anahatar[j, s])
                            {
                                sonuclar[h, s] = 100.0 / Convert.ToDouble(keykarakter.Length);
                                puan = puan + sonuclar[h, s];
                            }
                            else
                            {
                                sonuclar[h, s] = 0.0;
                            }
                        }
                    }
                }
                puanlar[h] = puan;
                puan = 0;
            }

            DataTable tablo = new DataTable();
            tablo.Columns.Add("Numara", typeof(string));
            tablo.Columns.Add("Ad-Soyad", typeof(string));


            for (int f = 0; f < keykarakter.Length; f++)
            {
                tablo.Columns.Add("Soru" + (f + 1), typeof(string));
                

            }
            tablo.Columns.Add("Puan", typeof(string));
            for (int g = 0; g < cvpgridview.Rows.Count; g++)
            {
                var dr = tablo.NewRow();
                dr["Numara"] = numaralar[g];
                dr["Ad-Soyad"] = isimler[g] + "-" + soyadlar[g];
                for (int a = 0; a < keykarakter.Length; a++)
                {
                    dr["Soru" + (a + 1)] = sonuclar[g, a].ToString("0.##");
                }
                dr["Puan"] = puanlar[g].ToString("0.##");
                tablo.Rows.Add(dr);
            }
            double[] soruort = new double[keykarakter.Length];
            double topla = 0;

            for (int k = 0; k < keykarakter.Length; k++)
            {

                for (int y = 0; y < cvpgridview.Rows.Count; y++)
                {
                    topla = topla + sonuclar[y, k];
                }
                soruort[k] = topla / Convert.ToDouble(cvpgridview.Rows.Count);
                topla = 0;
            }
            var dr2 = tablo.NewRow();
            dr2["Numara"] = "Ortalama";
            dr2["Ad-Soyad"] = " ";
            for (int a = 0; a < keykarakter.Length; a++)
            {
                dr2["Soru" + (a + 1)] = soruort[a].ToString("0.##");
            }
            dr2["Puan"] = " ";
            tablo.Rows.Add(dr2);
            sonuclargrid.DataSource = tablo;
            sonuclargrid.DataBind();

            double tampuan = 100.0 / Convert.ToDouble(keykarakter.Length);
            double[] soruyuzde = new double[keykarakter.Length];
            for(int b = 0; b < keykarakter.Length; b++)
            {
                soruyuzde[b] = (soruort[b] / tampuan)*100;
            }

            DataTable tablo2 = new DataTable();
            tablo2.Columns.Add("Soru-Numarası", typeof(string));
            tablo2.Columns.Add("Ortalaması(Puan)", typeof(string));
            tablo2.Columns.Add("Başarımı(%)", typeof(string));
            for(int h=0; h < keykarakter.Length; h++)
            {
                var dr3 = tablo2.NewRow();
                dr3["Soru-Numarası"] = "Soru " + (h + 1).ToString();
                dr3["Ortalaması(Puan)"] = soruort[h].ToString("0.##");
                dr3["Başarımı(%)"] = "%" + soruyuzde[h].ToString();
                tablo2.Rows.Add(dr3);
              
            }
            sorularyuzdegrid.DataSource = tablo2;
            sorularyuzdegrid.DataBind();
            btnexcel.Enabled = true;
        }
        public void yenidoldur()
        {
            

            DataTable tablo2 = new DataTable();
            tablo2.Columns.Add("Ad", typeof(string));
            tablo2.Columns.Add("Soyad", typeof(string));
            tablo2.Columns.Add("Numara", typeof(string));
            tablo2.Columns.Add("Grup", typeof(string));
            tablo2.Columns.Add("Cevaplar", typeof(string));
            for (int g = 0; g < cvpgridview.Rows.Count; g++)
            {
                var dr = tablo2.NewRow();
                dr["Ad"] = isimler[g];
                dr["Soyad"] = soyadlar[g];
                dr["Numara"] = numaralar[g];
                dr["Grup"] = gruplar[g];
                dr["Cevaplar"] = verilencvp[g];
                tablo2.Rows.Add(dr);
            }
            cvpgridview.DataSource = tablo2;
            cvpgridview.DataBind();

           
        }
        public void renkdoldur()
        {
            for (int a = 0; a < numaralar.Length; a++)
            {
                char[] numara = numaralar[a].ToCharArray();

                if (numaralar[a] == "")
                {
                   
                    cvpgridview.Rows[a].Cells[3].BackColor = System.Drawing.Color.Red;
                    continue;
                }
                else if (numara.Length != 9)
                {
                    cvpgridview.Rows[a].Cells[3].BackColor = System.Drawing.Color.Red;
                }
               

            }
            for (int b = 0; b < gruplar.Length; b++)
            {
                if (gruplar[b] == "")
                {
                   
                   cvpgridview.Rows[b].Cells[4].BackColor = System.Drawing.Color.Red;
                }
            }
            for (int c = 0; c < isimler.Length; c++)
            {
                if (isimler[c] == "")
                {
                    
                    cvpgridview.Rows[c].Cells[1].BackColor = System.Drawing.Color.Red;
                }
            }
            for (int d = 0; d < soyadlar.Length; d++)
            {
                if (soyadlar[d] == "")
                {
                   
                    cvpgridview.Rows[d].Cells[2].BackColor = System.Drawing.Color.Red;
                }
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
        }

        protected void cvpgridview_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            cvpgridview.EditIndex = -1;
            yenidoldur();
        }

        protected void cvpgridview_RowEditing(object sender, GridViewEditEventArgs e)
        {

            cvpgridview.EditIndex = e.NewEditIndex;
            yenidoldur();
            renkdoldur();
         
        }

        protected void cvpgridview_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            cvpgridview.EditIndex = -1;
            TextBox txtgridad = (TextBox)cvpgridview.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox txtgridsoyad = (TextBox)cvpgridview.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox txtgridnumara = (TextBox)cvpgridview.Rows[e.RowIndex].Cells[3].Controls[0];
            TextBox txtgridgrup = (TextBox)cvpgridview.Rows[e.RowIndex].Cells[4].Controls[0];
            TextBox txtverilencvp = (TextBox)cvpgridview.Rows[e.RowIndex].Cells[5].Controls[0];

            isimler[e.RowIndex] = txtgridad.Text;
            soyadlar[e.RowIndex] = txtgridsoyad.Text;
            numaralar[e.RowIndex] = txtgridnumara.Text;
            gruplar[e.RowIndex] = txtgridgrup.Text;
            verilencvp[e.RowIndex] = txtverilencvp.Text;
            yenidoldur();
            renkdoldur();
        }

        protected void btnonayla_Click(object sender, EventArgs e)
        {
            btndegerlendir.Enabled = true;
        }

        protected void btnexcel_Click(object sender, EventArgs e)
        {
            string dosyaadi = drpyil.SelectedItem.Text + "_" + drp_donem.SelectedItem.Text + "_" + drp_yariyil.SelectedItem.Text + "_" + drp_sinavtur.SelectedItem.Text + "_" + drp_bolum.SelectedItem.Text + "_" + drp_ders.SelectedItem.Text + "_" + "Soru_Bazli_Degerlendirme.xls";
            string kayit_dosya_adi = "attachement;filename=" + dosyaadi;
            Response.ClearContent();
            Response.Buffer = true;
            Response.AppendHeader("content-disposition",kayit_dosya_adi);
            Response.ContentType = "application/excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter ht = new HtmlTextWriter(sw);

            donustur(sonuclargrid);
            donustur(sorularyuzdegrid);

            Table tb = new Table();

            TableRow tr1 = new TableRow();

            TableCell cell1 = new TableCell();

            cell1.Controls.Add(sonuclargrid);

            tr1.Cells.Add(cell1);

            TableCell cell3 = new TableCell();

            cell3.Controls.Add(sorularyuzdegrid);

            TableCell cell2 = new TableCell();

            cell2.Text = "&nbsp;";

            TableRow tr2 = new TableRow();

            tr2.Cells.Add(cell2);

            TableRow tr3 = new TableRow();

            tr3.Cells.Add(cell3);

            tb.Rows.Add(tr1);

            tb.Rows.Add(tr2);

            tb.Rows.Add(tr3);

            tb.RenderControl(ht);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }
        public void donustur(GridView gelenview)
        {
            gelenview.AllowPaging = false;
           
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void btnsistemkayit_Click(object sender, EventArgs e)
        {
            string kul_sicil_aktif = Session["giriskulsicil"].ToString();
            fileexcel.SaveAs(Server.MapPath("sorubazlisonuc/") + fileexcel.FileName);
            string uzanti = (Server.MapPath("sorubazlisonuc/") + fileexcel.FileName).ToString();
            if (File.Exists(uzanti))
            {
                string filepathi = uzanti.Substring(uzanti.LastIndexOf('\\') + 1);
                DataSet1TableAdapters.soru_bazli_okutmaTableAdapter dt = new DataSet1TableAdapters.soru_bazli_okutmaTableAdapter();
                dt.insertsorubazli(Convert.ToInt32(drp_bolum.SelectedValue),Convert.ToInt32(drp_ders.SelectedValue),Convert.ToInt32(drpyil.SelectedValue),drp_sinavtur.SelectedItem.Text,drp_yariyil.SelectedItem.Text,Convert.ToInt32(kul_sicil_aktif),filepathi);
            }
        }
    }
}