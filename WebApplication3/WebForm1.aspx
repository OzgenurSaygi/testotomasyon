<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>
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
            top: 501px;
            left: 10px;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
       <div class="container">
        <div class="form-group was-validated">
            <div style="position:absolute; top: 13px; left: 10px; width: 679px">
                <asp:Label ID="lblsicil" runat="server" Text="Label" ><div style="padding-bottom:10px">Sicil No</div></asp:Label>
                <asp:TextBox ID="kul_sicil_no" runat="server" CssClass="form-control" placeholder="Sicilno" required></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
            <div style="position:absolute; top: 112px; left: 10px; width: 679px;">
                <asp:Label ID="lblkuladi" runat="server" Text="Label"><div style="padding-bottom:10px">Kullanıcı Adı</div></asp:Label>
                <asp:TextBox ID="kul_adi"  runat="server" CssClass="form-control" placeholder="Ad" required ></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
            <div style="position:absolute; top: 210px; left: 10px; width: 679px;">
                <asp:Label ID="lblsoyad" runat="server" Text="Label"><div style="padding-bottom:10px">Kullanıcı Soyadı</div></asp:Label>
                <asp:TextBox ID="kul_soyadi"  runat="server" CssClass="form-control" placeholder="Soyad" required></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
            <div style="position:absolute; top: 310px; left: 10px; width: 679px;">
                <asp:Label ID="lblsifre" runat="server" Text="Label"><div style="padding-bottom:10px">Şifre</div></asp:Label>
                <asp:TextBox ID="kul_sifre"  runat="server" CssClass="form-control" placeholder="Soyad" required></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
            <div class="auto-style2">
                <asp:Button ID="btnkaydet" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="btnkaydet_Click" />
            </div>
            <div class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Label"><div style="padding-bottom:10px">Kullanıcı Türü</div></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"  ></asp:DropDownList>
                
            </div>
        </div></div>
  
</asp:Content>

