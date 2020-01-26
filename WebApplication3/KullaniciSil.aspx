<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="KullaniciSil.aspx.cs" Inherits="WebApplication3.KullaniciSil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            position: absolute;
            left: 14px;
            top: 313px;
            width: 72px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container was-validated">
        <div class="form-group">
            <div style="position:absolute; top: 13px; left: 10px; width: 679px">
                <asp:Label ID="lblkullanicisilmesicil" runat="server" Text="Label" ><div style="padding-bottom:10px">Sicil No</div></asp:Label>
                <asp:TextBox ID="kullanicisilsicil" runat="server" CssClass="form-control" placeholder="Sicil No" required></asp:TextBox>
            </div>
            <div style="position:absolute; top: 123px; left: 10px; width: 679px">
                <asp:Label ID="Label1" runat="server" Text="Label" ><div style="padding-bottom:10px">Adi</div></asp:Label>
                <asp:TextBox ID="kullanicisilad" runat="server" CssClass="form-control" placeholder="Adi" required></asp:TextBox>
            </div>
            <div style="position:absolute; top: 213px; left: 10px; width: 679px">
                <asp:Label ID="Label2" runat="server" Text="Label" ><div style="padding-bottom:10px">Soyadı</div></asp:Label>
                <asp:TextBox ID="kullanicisilsoyad" runat="server" CssClass="form-control" placeholder="Soyadı" required></asp:TextBox>
            </div>
            <div class="auto-style3">
                <asp:Button ID="btnkaydet" runat="server" Text="Sil" CssClass="btn btn-primary" OnClick="btnkaydet_Click" Width="73px"  />
            </div>
            </div>
         </div>
</asp:Content>
