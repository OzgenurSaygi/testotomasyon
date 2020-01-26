<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true"  CodeBehind="KazanimBazliDegerlendirme.aspx.cs"   Inherits="WebApplication3.KazanimBazliDegerlendirme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            position: absolute;
            top: 726px;
            left: 9px;
            width: 499px;
           height: 330px;
           overflow:scroll;
    }
               
        .auto-style5 {
            position: absolute;
            left: 743px;
            top: 604px;
            height: 29px;
        }
         .auto-style6 {
            position: absolute;
            left: 749px;
            top: 12px;
            width: 274px;
            height: 214px;
            overflow:scroll;
            visibility:hidden;
            
        }
        .auto-style7 {
            position: absolute;
            left: 551px;
            top: 727px;
            width: 335px;
            height: 326px;
            overflow:scroll;
        }
        .auto-style8 {
            position: absolute;
            left: 550px;
            top: 663px;
        }
        .auto-style9 {
            position: absolute;
            top: 663px;
            left: 337px;
            width: 183px;
            height: 42px;
        }
        .auto-style10 {
            position: absolute;
            top: 664px;
            left: 13px;
            width: 707px;
        }
        .auto-style11 {
            position: absolute;
            top: 582px;
            left: 13px;
            width: 707px;
        }
        .auto-style12 {
            position: absolute;
            top: 496px;
            left: 13px;
            width: 707px;
        }
        .auto-style13 {
            position: absolute;
            top: 409px;
            left: 13px;
            width: 707px;
        }
        .auto-style14 {
            position: absolute;
            top: 325px;
            left: 13px;
            width: 707px;
        }
        .auto-style15 {
            position: absolute;
            top: 245px;
            left: 13px;
            width: 707px;
        }
        .auto-style16 {
            position: absolute;
            top: 167px;
            left: 13px;
            width: 707px;
        }
        .satirbosluk{
            margin-bottom:10px;
        }
        .auto-style18 {
            position: absolute;
            left: 6px;
            top: 1085px;
            width: 588px;
            height: 64px;
        }
        .auto-style19 {
            position: absolute;
            left: 609px;
            top: 1117px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
     <div class="form-group was-validated">
         <div style="position:absolute; top: 10px; left: 13px; width: 707px;">
        <asp:Label ID="lblbolum" runat="server" Text="Label"><div style="padding-bottom:10px">Bölümü Seçiniz</div></asp:Label>
        <asp:DropDownList ID="drp_bolum" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="drp_bolum_SelectedIndexChanged"></asp:DropDownList>
       </div>
           <div class="auto-style16">
              <asp:Label ID="Label3" runat="server" Text="Label"><div style="padding-bottom:10px">Dönem Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drp_donem" AutoPostBack="true" class="form-control" runat="server"  Width="707px" >

                    <asp:ListItem>Güz</asp:ListItem>
                    <asp:ListItem>Bahar</asp:ListItem>
                    <asp:ListItem>Yaz</asp:ListItem>

                    </asp:DropDownList>
                 </div>
           <div style="position:absolute; top: 90px; left: 13px; width: 707px;">
        <asp:Label ID="lblyil" runat="server" Text="Label"><div style="padding-bottom:10px">Yıl Seçiniz</div></asp:Label>
        <asp:DropDownList ID="drpyil" CssClass="form-control" AutoPostBack="true" runat="server" ></asp:DropDownList>
       </div>
          <div class="auto-style15">
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
      
          <div class="auto-style14">
        <asp:Label ID="Label1" runat="server" Text="Label"><div style="padding-bottom:10px">Sınav Türünü Seçiniz</div></asp:Label>
        <asp:DropDownList ID="drp_sinavtur" CssClass="form-control" runat="server">
            <asp:ListItem>Vize</asp:ListItem>
            <asp:ListItem>Final</asp:ListItem>
            <asp:ListItem>Bütünleme</asp:ListItem>
        </asp:DropDownList>
       </div>
        <div class="auto-style13">
        <asp:Label ID="lblders" runat="server" Text="Label"><div style="padding-bottom:10px">Dersi Seçiniz</div></asp:Label>
        <asp:DropDownList ID="drp_ders" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="drp_ders_SelectedIndexChanged">
        </asp:DropDownList>
       </div>
        <div class="auto-style12">
        <asp:Label ID="Label2" runat="server" Text="Label"><div style="padding-bottom:10px">Dersin Kazanımları</div></asp:Label>
        <asp:DropDownList ID="drp_kazanim" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>

        <div class="auto-style11">
        <asp:Label ID="lbldosya" runat="server" Text="Label"><div style="padding-bottom:10px">Cevap Anahtarını Yükleyiniz</div></asp:Label>
        <div class="form-group">
        <asp:FileUpload ID="FileCvpKey" CssClass="form-control-file border" runat="server" />
        </div>
        </div>
        <div class="auto-style5"><asp:Button ID="yukle" runat="server" CssClass="btn btn-primary" Text="Yükle" OnClick="yukle_Click" Width="69px" Height="37px" /></div>
         <div class="auto-style10">
             <asp:Button ID="btnkazanimsecim" runat="server" Enabled="false" Text="Kazanımları Seçmek İçin Tıklayınız" OnClick="btnkazanimsecim_Click" CssClass="btn btn-danger" />
         </div>
         <div class="auto-style9">
             <asp:Button ID="btnkaydet" Enabled="false" runat="server" Text="Değerlendir " CssClass="btn btn-primary" Height="39px"  OnClick="btnkaydet_Click" Width="167px"   />
         </div>
         <div id="tablediv" runat="server" class="auto-style2" >
             <asp:GridView ID="sorukazgrid"  runat="server" CssClass="table table-bordered table-hover"  BorderStyle="Solid" BorderWidth="1px" Height="190px" Width="368px" ></asp:GridView>
        </div>
        <div class="auto-style6"><asp:GridView ID="cvpkeygridview" runat="server"  BorderStyle="Solid" BorderWidth="1px" ></asp:GridView></div>
         <div class="auto-style7">
             <asp:GridView ID="sonucgrid" BorderStyle="Solid" BorderWidth="1px" runat="server"></asp:GridView>
         </div>
         <div class="auto-style8"><asp:Button ID="btneexcel" CssClass="btn btn-primary" Enabled="false" OnClick="btneexcel_Click"   runat="server" Text="Excele Dönüştür" /></div>
        <div class="auto-style18">
            <asp:Label ID="lblyazi" CssClass="satirbosluk" runat="server" Text=""><div style="padding-bottom:10px">Oluşturduğunuz excel dosyasını sisteme kayıt ediniz</div></asp:Label>
         <div class="form-group">
             <asp:FileUpload ID="fileexcel"  CssClass="form-control-file border"   runat="server" Height="31px" Width="577px" />
         </div>
        </div>
         <div class="auto-style19"><asp:Button ID="btnsistemkayit" runat="server" Text="Sisteme Kaydet " CssClass="btn btn-primary"  OnClick="btnsistemkayit_Click"   /></div>
     </div>
    </div>
</asp:Content>
