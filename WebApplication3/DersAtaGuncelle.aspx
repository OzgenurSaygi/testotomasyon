<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DersAtaGuncelle.aspx.cs" Inherits="WebApplication3.DersAtaGuncelle" %>
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
            top: 642px;
            left: 8px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container was-validated">
        <div class="form-group">
            <div style="position:absolute; top: 13px; left: 10px; width: 679px">
                <asp:Label ID="lblid" runat="server" Text="Label" ><div style="padding-bottom:10px">ID</div></asp:Label>
                <asp:TextBox ID="txtsicil" runat="server" CssClass="form-control" placeholder="ID" required></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
             
            <div style="position:absolute; top: 112px; left: 10px; width: 679px;">
                  <asp:Label ID="Label4" runat="server" Text="Label"><div style="padding-bottom:10px">Adı</div></asp:Label>
                <asp:DropDownList ID="drpad" class="form-control" runat="server"  Width="679px">
                </asp:DropDownList>
                
            </div>
             <div style="position:absolute; top: 212px; left: 10px; width: 679px;">
                  <asp:Label ID="lbldrpblm" runat="server" Text="Label"><div style="padding-bottom:10px">Bölüm Adını Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drpbolum" class="form-control" runat="server"  Width="679px" AutoPostBack="true" OnSelectedIndexChanged="drpbolum_SelectedIndexChanged">
                </asp:DropDownList>
                
            </div>
            <div style="position:absolute; top: 312px; left: 10px; width: 679px;">
                  <asp:Label ID="Label1" runat="server" Text="Label"><div style="padding-bottom:10px">Ders Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drpders" class="form-control" runat="server"  Width="679px">
                </asp:DropDownList>
                
            </div>
            <div style="position:absolute; top: 412px; left: 10px; width: 679px;">
                  <asp:Label ID="Label2" runat="server" Text="Label"><div style="padding-bottom:10px">Donem</div></asp:Label>
                <asp:DropDownList ID="drpdonem" class="form-control" runat="server"  Width="679px">
                </asp:DropDownList>
                
            </div>
            <div style="position:absolute;top:512px; left:7px; width:670px">
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
            <div class="auto-style2">
                <asp:Button ID="btnkaydet" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="btnkaydet_Click"   />
            </div>
            </div>
         </div>
    
</asp:Content>
