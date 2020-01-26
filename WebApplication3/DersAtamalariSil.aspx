<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DersAtamalariSil.aspx.cs" Inherits="WebApplication3.DersAtamalariSil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style3 {
            position: absolute;
            left: 14px;
            top: 415px;
            width: 72px;
             height: 34px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container was-validated">
        <div class="form-group">
            <div style="position:absolute; top: 13px; left: 10px; width: 679px">
                <asp:Label ID="lbldersatamasilid" runat="server" Text="Label" ><div style="padding-bottom:10px">ID</div></asp:Label>
                <asp:TextBox ID="dersatamasilid" runat="server" CssClass="form-control" placeholder="ID" required></asp:TextBox>
            </div>
            <div style="position:absolute; top: 113px; left: 10px; width: 679px">
                <asp:Label ID="Label1" runat="server" Text="Label" ><div style="padding-bottom:10px">Sicil No</div></asp:Label>
                <asp:TextBox ID="dersatamasilsicilno" runat="server" CssClass="form-control" placeholder="Sicil No" required></asp:TextBox>
            </div>
            <div style="position:absolute; top: 213px; left: 10px; width: 679px">
                <asp:Label ID="Label2" runat="server" Text="Label" ><div style="padding-bottom:10px">Adı</div></asp:Label>
                <asp:TextBox ID="dersatamasilad" runat="server" CssClass="form-control" placeholder="Adı" required></asp:TextBox>
            </div>
             <div style="position:absolute; top: 313px; left: 10px; width: 679px">
                <asp:Label ID="Label3" runat="server" Text="Label" ><div style="padding-bottom:10px">Ders Adı</div></asp:Label>
                <asp:TextBox ID="dersatamasilders" runat="server" CssClass="form-control" placeholder="Adı" required></asp:TextBox>
            </div>
            <div class="auto-style3">
                <asp:Button ID="btnsil" runat="server" Text="Sil" CssClass="btn btn-primary" OnClick="btnkaydet_Click" Width="81px" Height="36px"  />
            </div>
            </div>
         </div>
    
</asp:Content>
