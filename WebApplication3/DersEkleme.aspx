<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DersEkleme.aspx.cs" Inherits="WebApplication3.DersEkleme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 637px;
            left: 5px;
            width: 560px;
        }
        .auto-style2 {
            position: absolute;
            top: 795px;
            left: 5px;
            width: 298px;
            height: 122px;
        }
        .auto-style3 {
            position: absolute;
            top: 462px;
            left: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
        <div class="form-group was-validated">
            <div style="position:absolute;width:679px; top: -2px; left: 6px;" >
                <asp:Label ID="lblderskodu" runat="server" Text="Label"><div style="padding-bottom:10px">Ders Kodu</div></asp:Label>
                <asp:TextBox ID="txtderskodu" runat="server" CssClass="form-control" placeholder="Ders Adını Giriniz "></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
            <div style="position:absolute; top: 93px; left: 6px; width: 679px">
                <asp:Label ID="lbldersAdi" runat="server" Text="Label"><div style="padding-bottom:10px">Ders Adı</div></asp:Label>
                <asp:TextBox ID="txtDers" runat="server" CssClass="form-control" placeholder="Ders Adını Giriniz " ></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>

             <div style="position:absolute;top:198px; left:6px; width:670px">
              <asp:Label ID="Label2" runat="server" Text="Label"><div style="padding-bottom:10px">Bölüm Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drpbolumlistesi" AutoPostBack="True" OnSelectedIndexChanged="drpdersliste_SelectedIndexChanged" class="form-control" runat="server"  Width="679px" >
                </asp:DropDownList>
                </div>

            <div style="position:absolute;top:379px; left:7px; width:670px">
              <asp:Label ID="Label1" runat="server" Text="Label"><div style="padding-bottom:10px">Yarıyıl Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drp_yariyil" class="form-control" runat="server"  Width="679px" >

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
            <div style="position:absolute;top:286px; left:7px; width:670px">
              <asp:Label ID="Label3" runat="server" Text="Label"><div style="padding-bottom:10px">Dönem Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drp_donem" class="form-control" runat="server"  Width="679px" >
                    </asp:DropDownList>
                </div>
            <div style="position:absolute; top: 592px; left: 4px;">
                <div style="position:absolute; top: -37px; left: 1px; margin-top: 0px;"><asp:Label ID="lbldersliste" runat="server" Text="Label"><div style="padding-bottom:10px">Öğrenme Çıktısı Ekleyeceğiniz Dersi Seçiniz</div></asp:Label>
</div>
                <asp:DropDownList ID="drpdersliste" runat="server" CssClass="form-control" Width="679px"></asp:DropDownList>
            </div>
            <div class="auto-style1">
                <asp:Label ID="Label4" runat="server" Text="Ders Öğrenme Çıktısı Ekleyiniz"></asp:Label>
            </div>
            <div style="position:absolute; top: 674px; left: 5px; height: 22px; width: 679px;">
                <asp:TextBox ID="txtcikti" runat="server" CssClass="form-control" placeholder="Öğrenme Çıktısı" ></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
            <div style="position:absolute; top: 738px; left: 6px; height: 29px; width: 86px; margin-top: 0px;">
                <asp:Button ID="btnciktiekle" runat="server" Text="Ekle" CssClass="btn btn-primary" Height="37px" Width="75px" OnClick="btnciktiekle_Click" />
            </div> 

             <div class="auto-style3">
               <asp:Button ID="btnkaydet_ders" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="btnkaydet_ders_Click" />
             </div>
              <div class="auto-style2">
                <asp:ListBox ID="ListBox1" runat="server" Height="116px" Width="235px"  ></asp:ListBox>
              </div>

            </div>
           </div>

</asp:Content>

