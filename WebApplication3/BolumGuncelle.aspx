<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BolumGuncelle.aspx.cs" Inherits="WebApplication3.BolumGuncelle" %>
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
            top: 513px;
            left: 11px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container was-validated">
        <div class="form-group">
            <div style="position:absolute; top: 13px; left: 10px; width: 679px">
                <asp:Label ID="lblbolumid" runat="server" Text="Label" ><div style="padding-bottom:10px">Bölüm ID</div></asp:Label>
                <asp:TextBox ID="bolum_id" runat="server" CssClass="form-control" placeholder="Bölüm ID" required></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
             <div style="position:absolute; top: 112px; left: 10px; width: 679px;">
                  <asp:Label ID="Label2" runat="server" Text="Label"><div style="padding-bottom:10px">Fakülte Adını Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drpfakulte" class="form-control" runat="server"  Width="679px">
                </asp:DropDownList>
               
            </div>
             <div style="position:absolute; top: 210px; left: 10px; width: 679px;">
                <asp:Label ID="lblbolum" runat="server" Text="Label"><div style="padding-bottom:10px">Bölüm Adı</div></asp:Label>
                <asp:TextBox ID="bol_ad"  runat="server" CssClass="form-control" placeholder="Bölüm Adı" ></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
             <div style="position:absolute; top: 410px; left: 10px; width: 679px;">
                <asp:Label ID="lblkazanım" runat="server" Text="Label"><div style="padding-bottom:10px">Kazanım</div></asp:Label>
                <asp:TextBox ID="kazanım"  runat="server" CssClass="form-control" placeholder="Kazanım" ></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
             <div style="position:absolute; top: 310px; left: 10px; width: 679px;">
                <asp:Label ID="Label1" runat="server" Text="Label"><div style="padding-bottom:10px">Kazanım ID</div></asp:Label>
                <asp:TextBox ID="TextBox1"  runat="server" CssClass="form-control" placeholder="Kazanım" ></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
             <div class="auto-style2">
                <asp:Button ID="btnkaydet" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="btnkaydet_Click"   />
            </div>
            </div>
         </div>
    
</asp:Content>
