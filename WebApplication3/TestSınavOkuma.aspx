<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master"  AutoEventWireup="true" CodeBehind="TestSınavOkuma.aspx.cs" Inherits="WebApplication3.TestSınavOkuma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            left: 772px;
            top: 491px;
            height: 29px;
        }
        .auto-style2 {
            position: absolute;
            left: 13px;
            top: 667px;
            width: 555px;
            height: 253px;
            overflow:scroll;
        }
        .auto-style3 {
            position: absolute;
            left: 530px;
            top: 629px;
            width: 93px;
            height: 17px;
        }
        .auto-style4 {
            position: absolute;
            left: 771px;
            top: 572px;
            width: 69px;
            height: 30px;
        }
        .auto-style5 {
            position: absolute;
            left: 619px;
            top: 663px;
            width: 383px;
            height: 257px;
            overflow:scroll;
        }
        .auto-style6 {
            position: absolute;
            left: 10px;
            top: 936px;
            width: 417px;
            overflow:scroll;
            height: 236px;
        }
        .auto-style7 {
            position: absolute;
            left: 16px;
            top: 621px;
            width: 114px;
        }
        .auto-style8 {
            position: absolute;
            top: 621px;
            left: 150px;
        }
        .auto-style9 {
            position: absolute;
            left: 292px;
            top: 621px;
        }
         .auto-style18 {
            position: absolute;
            left: 8px;
            top: 1188px;
            width: 588px;
            height: 64px;
        }
        .auto-style19 {
            position: absolute;
            left: 610px;
            top: 1218px;
            margin-top: 0px;
        }
        .auto-style20 {
            position: absolute;
            top: 69px;
            left: 13px;
            width: 707px;
        }
        .auto-style21 {
            position: absolute;
            top: 540px;
            left: 13px;
            width: 707px;
        }
        .auto-style22 {
            position: absolute;
            top: 458px;
            left: 13px;
            width: 707px;
        }
        .auto-style23 {
            position: absolute;
            top: 378px;
            left: 13px;
            width: 707px;
        }
        .auto-style24 {
            position: absolute;
            top: 297px;
            left: 13px;
            width: 707px;
        }
        .auto-style25 {
            position: absolute;
            top: 225px;
            left: 13px;
            width: 707px;
        }
        .auto-style26 {
            position: absolute;
            top: 145px;
            left: 13px;
            width: 707px;
        }
        .auto-style27 {
            position: absolute;
            top: -7px;
            left: 13px;
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
         <div class="auto-style1"><asp:Button ID="yukle" runat="server" CssClass="btn btn-primary" Text="Yükle" OnClick="yukle_Click" Width="69px" Height="37px" /></div>
         <div class="auto-style21">
        <asp:Label ID="lblcvpkey" runat="server" Text="Label"><div style="padding-bottom:10px">Cevap Anahtarını Yükleyiniz</div></asp:Label>
        <div class="form-group">
        <asp:FileUpload ID="FileCvpKey" CssClass="form-control-file border" runat="server" />
        </div>
       </div>
         <div class="auto-style4"><asp:Button ID="yukle2" runat="server" CssClass="btn btn-primary" Text="Yükle2" OnClick="yukle2_Click" Height="35px"/></div>
         <div class="auto-style8">
             <asp:Button ID="btndegerlendir" CssClass="btn btn-primary" Enabled="false" runat="server" Text="Değerlendir" OnClick="btndegerlendir_Click" />
              </div>
           <div class="auto-style2">
               <asp:GridView ID="cvpgridview" CssClass="table table-bordered table-hover " OnRowEditing="cvpgridview_RowEditing" OnRowCancelingEdit="cvpgridview_RowCancelingEdit" OnRowUpdating="cvpgridview_RowUpdating"  runat="server" BorderStyle="Solid" BorderWidth="1px"  >
                   <Columns>
                       <asp:CommandField ShowEditButton="True" />
                   </Columns>
               </asp:GridView>
           </div>
         <div class="auto-style3">
             <asp:Label ID="lbldeneme" runat="server" Text=""></asp:Label></div>
         <div class="auto-style5"><asp:GridView ID="cvpkeygridview" CssClass="table table-bordered table-hover "  runat="server" BorderStyle="Solid" BorderWidth="1px" ></asp:GridView></div>
         <div class="auto-style6"><asp:GridView ID="sonuclargrid"  CssClass="table table-bordered table-hover "  runat="server" BorderStyle="Solid" BorderWidth="1px" Width="281px" ></asp:GridView></div>
        <div class="auto-style7"><asp:Button ID="btnonayla" OnClick="btnonayla_Click" CssClass="btn btn-primary" runat="server" Text="Onayla" Width="112px" /></div>
         <div class="auto-style9"><asp:Button ID="btneexcel" CssClass="btn btn-primary" OnClick="btneexcel_Click" Enabled="false" runat="server" Text="Excele Dönüştür" /></div>
          <div class="auto-style18">
            <asp:Label ID="lblyazi" CssClass="satirbosluk" runat="server" Text=""><div style="padding-bottom:10px">Oluşturduğunuz excel dosyasını sisteme kayıt ediniz</div></asp:Label>
         <div class="form-group">
             <asp:FileUpload ID="fileexcel"  CssClass="form-control-file border"   runat="server" Height="31px" Width="577px" />
         </div>
        </div>
         <div class="auto-style19"><asp:Button ID="btnsistemkayit" runat="server" Text="Sisteme Kaydet " CssClass="btn btn-primary" OnClick="btnsistemkayit_Click"  /></div>
     </div>
    </div>
    
    
</asp:Content>
