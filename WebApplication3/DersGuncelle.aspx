<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DersGuncelle.aspx.cs" Inherits="WebApplication3.DersGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            left: 10px;
            top: 412px;
            width: 680px;
        }
        .auto-style2 {
            position: absolute;
            top: 724px;
            left: 11px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container was-validated">
        <div class="form-group">
            <div style="position:absolute; top: 13px; left: 10px; width: 679px">
                <asp:Label ID="lblderskod" runat="server" Text="Label" ><div style="padding-bottom:10px">Ders Kodu</div></asp:Label>
                <asp:TextBox ID="derskodu" runat="server" CssClass="form-control" placeholder="Ders Kodu" required></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
            <div style="position:absolute; top: 112px; left: 10px; width: 679px;">
                  <asp:Label ID="lbldrpblm" runat="server" Text="Label"><div style="padding-bottom:10px">Bölüm Adını Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drpbolum" class="form-control" runat="server"  Width="679px">
                </asp:DropDownList>
                
            </div>
             <div style="position:absolute; top: 212px; left: 10px; width: 679px;">
                  <asp:Label ID="Label2" runat="server" Text="Label"><div style="padding-bottom:10px">Öğretim Yılı</div></asp:Label>
                <asp:DropDownList ID="drpogretimyili" class="form-control" runat="server"  Width="679px">
                </asp:DropDownList>
                
            </div>
            
            <div style="position:absolute;top:312px; left:7px; width:670px">
              <asp:Label ID="Label3" runat="server" Text="Label"><div style="padding-bottom:10px">Yarıyıl Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drpyariyil" class="form-control" runat="server"  Width="679px" >

                    <asp:ListItem Value="1.Yarıyıl">1.Yarıyıl</asp:ListItem>
                    <asp:ListItem Value="2.Yarıyıl">2.Yarıyıl</asp:ListItem>
                    <asp:ListItem Value="3.Yarıyıl">3.Yarıyıl</asp:ListItem>
                    <asp:ListItem Value="4.Yarıyıl">4.Yarıyıl</asp:ListItem>
                    <asp:ListItem Value="5.Yarıyıl">5.Yarıyıl</asp:ListItem>
                    <asp:ListItem Value="6.Yarıyıl">6.Yarıyıl</asp:ListItem>
                    <asp:ListItem Value="7.Yarıyıl">7.Yarıyıl</asp:ListItem>
                    <asp:ListItem Value="8.Yarıyıl">8.Yarıyıl</asp:ListItem>
                    </asp:DropDownList>
                </div>
            <div style="position:absolute; top: 412px; left: 10px; width: 679px">
                <asp:Label ID="Label4" runat="server" Text="Label" ><div style="padding-bottom:10px">Ders Adı</div></asp:Label>
                <asp:TextBox ID="dersadi" runat="server" CssClass="form-control" placeholder="Ders Adı" required></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
            <div style="position:absolute; top: 512px; left: 10px; width: 679px">
                <asp:Label ID="lblid" runat="server" Text="Label" ><div style="padding-bottom:10px">Öğrenme Çıktısı ID</div></asp:Label>
                <asp:TextBox ID="ogrciktiid" runat="server" CssClass="form-control" placeholder="ID" required></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
            <div style="position:absolute; top: 612px; left: 10px; width: 679px">
                <asp:Label ID="Label5" runat="server" Text="Label" ><div style="padding-bottom:10px">Öğrenme Çıktısı</div></asp:Label>
                <asp:TextBox ID="ogrenmecikti" runat="server" CssClass="form-control" placeholder="Öğrenme Çıktısı" required></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
             <div class="auto-style2">
                <asp:Button ID="btnkaydet" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="btnkaydet_Click"   />
            </div>
            </div>
        </div>
    
</asp:Content>
