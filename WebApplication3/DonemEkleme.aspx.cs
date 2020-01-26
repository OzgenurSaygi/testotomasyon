using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class DonemEkleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelen = Session["girissicil"].ToString();
            Button btn = this.Master.FindControl("btnlogin") as Button;
            if (btn != null)
            {

                btn.Text = "SİCİL NO:" + " - " + gelen;
            }
        }
        protected void btnkaydet_dnm_Click(object sender, EventArgs e)
        {
             DataSet1TableAdapters.donem_bilgileriTableAdapter dt = new DataSet1TableAdapters.donem_bilgileriTableAdapter();
            dt.DonemInsert(txtDonem.Text, drp_donem.SelectedItem.ToString());
            Response.Redirect("DonemEkleme.Aspx");
        }
        
    }
}