<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" EnableEventValidation = "false" AutoEventWireup="true" CodeBehind="SoruBazliOkuma.aspx.cs" Inherits="WebApplication3.SoruBazliOkuma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
         .auto-style4 {
            position: absolute;
            left: 772px;
            top: 583px;
            width: 69px;
            height: 30px;
        }
          .auto-style1 {
            position: absolute;
            left: 772px;
            top: 498px;
            height: 29px;
        }
           .auto-style2 {
            position: absolute;
            left: 5px;
            top: 684px;
            width: 520px;
            height: 243px;
            overflow:scroll;
           

        }
            .auto-style5 {
            position: absolute;
            left: 572px;
            top: 682px;
            width: 396px;
            height: 245px;
            margin-top: 0px;
            overflow:scroll;
        }
        .auto-style6 {
            position: absolute;
            left: 7px;
            top: 959px;
            width: 962px;
            overflow:scroll;
            height: 235px;
           
        }
        .auto-style7 {
            position: absolute;
            left: 4px;
            top: 1212px;
            width: 496px;
            height: 224px;
            overflow:scroll;
            
        }
        .auto-style8 {
            position: absolute;
            left: 12px;
            top: 639px;
            width: 135px;
        }
        .auto-style9 {
            position: absolute;
            top: 638px;
            left: 167px;
        }
        .auto-style10 {
            position: absolute;
            left: 388px;
            top: 638px;
        }
         .auto-style18 {
            position: absolute;
            left: 0px;
            top: 1454px;
            width: 588px;
            height: 64px;
        }
        .auto-style19 {
            position: absolute;
            left: 611px;
            top: 1487px;
            margin-top: 0px;
        }
         .auto-style20 {
            position: absolute;
            top: 70px;
            left: 13px;
            width: 707px;
        }
    .auto-style21 {
        position: absolute;
        top: 551px;
        left: 13px;
        width: 707px;
    }
    .auto-style22 {
        position: absolute;
        top: 467px;
        left: 13px;
        width: 707px;
    }
    .auto-style23 {
        position: absolute;
        top: 388px;
        left: 13px;
        width: 707px;
    }
    .auto-style24 {
        position: absolute;
        top: 307px;
        left: 13px;
        width: 707px;
    }
    .auto-style25 {
        position: absolute;
        top: 227px;
        left: 13px;
        width: 707px;
    }
    .auto-style26 {
        position: absolute;
        top: 151px;
        left: 13px;
        width: 707px;
    }
    .auto-style27 {
        position: absolute;
        top: -5px;
        left: 12px;
        width: 707px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="container">
     <div class="form-group was-validated">
         <div class="auto-style27">
        <asp:Label ID="lblbolum" runat="server" Text="Label"><div style="padding-bottom:10px">Bölümü Seçiniz</div></asp:Label>
        <asp:DropDownList ID="drp_bolum" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="drp_bolum_SelectedIndexChanged"></asp:DropDownList>
       </div>
           <div class="auto-style26">
              <asp:Label ID="Label2" runat="server" Text="Label"><div style="padding-bottom:10px">Dönem Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drp_donem" class="form-control" runat="server"  Width="707px" >

                    <asp:ListItem>Güz</asp:ListItem>
                    <asp:ListItem>Bahar</asp:ListItem>
                    <asp:ListItem>Yaz</asp:ListItem>

                    </asp:DropDownList>
            </div>
         <div class="auto-style20">
        <asp:Label ID="lblyil" runat="server" Text="Label"><div style="padding-bottom:10px">Yıl Seçiniz</div></asp:Label>
        <asp:DropDownList ID="drpyil" CssClass="form-control" AutoPostBack="true" runat="server" ></asp:DropDownList>
       </div>
         <div class="auto-style25">
        <asp:Label ID="lblyariyil" runat="server" Text="Label"><div style="padding-bottom:10px">Yarıyıl Seçiniz</div></asp:Label>
        <asp:DropDownList ID="drp_yariyil" CssClass="form-control" runat="server">
            <asp:ListItem>1.Yarıyıl</asp:ListItem>
            <asp:ListItem>2.Yarıyıl</asp:ListItem>
            <asp:ListItem>3.Yarıyıl</asp:ListItem>
            <asp:ListItem>4.Yarıyıl</asp:ListItem>
            <asp:ListItem>5.Yarıyıl</asp:ListItem>
            <asp:ListItem>6.Yarıyıl</asp:ListItem>
            <asp:ListItem>7.Yarıyıl</asp:ListItem>
            <asp:ListItem>8.Yarıyıl</asp:ListItem>
        </asp:DropDownList>
       </div>
       <div class="auto-style24">
        <asp:Label ID="lblders" runat="server" Text="Label"><div style="padding-bottom:10px">Dersi Seçiniz</div></asp:Label>
        <asp:DropDownList ID="drp_ders" AutoPostBack="true" CssClass="form-control" runat="server"></asp:DropDownList>
       </div>
          <div class="auto-style23">
        <asp:Label ID="Label1" runat="server" Text="Label"><div style="padding-bottom:10px">Sınav Türünü Seçiniz</div></asp:Label>
        <asp:DropDownList ID="drp_sinavtur" CssClass="form-control" runat="server">
            <asp:ListItem>Vize</asp:ListItem>
            <asp:ListItem>Final</asp:ListItem>
            <asp:ListItem>Bütünleme</asp:ListItem>
        </asp:DropDownList>
       </div>
         <div class="auto-style22">
        <asp:Label ID="lbldosya" runat="server" Text="Label"><div style="padding-bottom:10px">Sınav Dosyasını Yükleyiniz</div></asp:Label>
        <div class="form-group">
          <asp:FileUpload ID="FileVeriler" CssClass="form-control-file border" runat="server" />
        </div>
       </div>
        <div class="auto-style1"><asp:Button ID="yukle" runat="server" CssClass="btn btn-primary" Text="Yükle"  Width="69px" Height="37px" OnClick="yukle_Click" /></div>
        <div class="auto-style21">
        <asp:Label ID="lblcvpkey" runat="server" Text="Label"><div style="padding-bottom:10px">Cevap Anahtarını Yükleyiniz</div></asp:Label>
        <div class="form-group">
        <asp:FileUpload ID="FileCvpKey" CssClass="form-control-file border" runat="server" />
        </div>
       </div>
       <div class="auto-style4"><asp:Button ID="yukle2" runat="server" CssClass="btn btn-primary" Text="Yükle2"  Height="35px" OnClick="yukle2_Click"/></div>
        <div class="auto-style9">
        <asp:Button ID="btndegerlendir" Enabled="false" CssClass="btn btn-primary" runat="server" Text="Soru Bazlı Değerlendir" OnClick="btndegerlendir_Click" />
        </div>   
          <div class="auto-style2"  id="cvpgriddiv">
               <asp:GridView ID="cvpgridview"  runat="server" OnRowCancelingEdit="cvpgridview_RowCancelingEdit" OnRowEditing="cvpgridview_RowEditing" OnRowUpdating="cvpgridview_RowUpdating" CssClass="table table-bordered table-hover " BorderStyle="Solid" BorderWidth="1px" Height="222px" Width="474px">
                   <Columns>
                       <asp:CommandField ShowEditButton="True" />
                   </Columns>
               </asp:GridView>
           </div>
         <div class="auto-style5" ><asp:GridView ID="cvpkeygridview" CssClass="table table-bordered table-hover " runat="server" BorderStyle="Solid" BorderWidth="1px" ></asp:GridView></div>
         <div class="auto-style6"><asp:GridView ID="sonuclargrid" CssClass="table table-bordered table-hover "  runat="server" BorderStyle="Solid" BorderWidth="1px" Width="281px" ></asp:GridView></div>
         <div class="auto-style7"><asp:GridView ID="sorularyuzdegrid" CssClass="table table-bordered table-hover " runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:GridView></div>
         <div class="auto-style8"><asp:Button OnClick="btnonayla_Click" ID="btnonayla" CssClass="btn btn-primary" runat="server" Text="Onayla" Width="135px" /></div>
         <div class="auto-style10"><asp:Button ID="btnexcel" Enabled="false" OnClick="btnexcel_Click" runat="server" CssClass="btn btn-primary" Text="Excele Dönüştür" /></div>
        <div class="auto-style18">
            <asp:Label ID="lblyazi" CssClass="satirbosluk" runat="server" Text=""><div style="padding-bottom:10px">Oluşturduğunuz excel dosyasını sisteme kayıt ediniz</div></asp:Label>
         <div class="form-group">
             <asp:FileUpload ID="fileexcel"  CssClass="form-control-file border"   runat="server" Height="31px" Width="577px" />
         </div>
        </div>
         <div class="auto-style19"><asp:Button ID="btnsistemkayit" runat="server" Text="Sisteme Kaydet " CssClass="btn btn-primary" OnClick="btnsistemkayit_Click" /></div>
         
     
     </div>
    </div>

</asp:Content>
