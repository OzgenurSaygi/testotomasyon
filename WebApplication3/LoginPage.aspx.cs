﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace WebApplication3
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadmingiris_Click(object sender, EventArgs e)
        {
            if (txtkuladi.Text == "" || txtkulsifre.Text == "")
            {
                lbluyari.Text = "Boş alanları doldurunuz";
            }
            else { 
            int sicil = Convert.ToInt32(txtkuladi.Text);
            SqlConnection con;
            SqlCommand cmd;
            string constring = ConfigurationManager.ConnectionStrings["OptikOkuyucuDbConnectionString"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand("select*from Egitimci_Bilgileri_Db where sicil_no=@kul_sicil_no and sifre=@kul_sifre and kullanici_tur_id=1",con);
            cmd.Parameters.AddWithValue("@kul_sicil_no",sicil);
            cmd.Parameters.AddWithValue("@kul_sifre",txtkulsifre.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                    string isim=dr["adi"].ToString();
                    Session.Add("girissicil", txtkuladi.Text);
                    Response.Redirect("~/WebForm1.Aspx");
                    
            }
            else
            {
                lbluyari.Text = "Hatalı Giriş";
            }
            con.Close();
                txtkuladi.Text = "";
                txtkulsifre.Text = "";
                lbluyari.Text = "";
            }
        }
    }
}