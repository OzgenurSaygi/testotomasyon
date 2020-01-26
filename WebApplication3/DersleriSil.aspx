<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DersleriSil.aspx.cs" Inherits="WebApplication3.DersleriSil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style3 {
            position: absolute;
            left: 11px;
            top: 230px;
            width: 72px;
             right: 247px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container was-validated">
        <div class="form-group">
            <div style="position:absolute; top: 13px; left: 10px; width: 679px">
                <asp:Label ID="lbl" runat="server" Text="Label" ><div style="padding-bottom:10px">Ders Kodu</div></asp:Label>
                <asp:TextBox ID="derssilkod" runat="server" CssClass="form-control" placeholder="Ders Kodu" required></asp:TextBox>
            </div>
            <div style="position:absolute; top: 113px; left: 10px; width: 679px">
                <asp:Label ID="Label1" runat="server" Text="Label" ><div style="padding-bottom:10px">Ders Adı</div></asp:Label>
                <asp:TextBox ID="derssilad" runat="server" CssClass="form-control" placeholder="Ders Adı" required></asp:TextBox>
            </div>
             <div class="auto-style3">
                <asp:Button ID="btnkaydet" runat="server" Text="Sil" CssClass="btn btn-primary" OnClick="btnkaydet_Click" Width="73px"  />
            </div>
            </div>
        </div>
    
</asp:Content>
