<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DersAtama.aspx.cs" Inherits="WebApplication3.DersAtama" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
        <div class="form-group was-validated">
            <div style="position:absolute; top: 7px; left: 5px; width: 679px">
                <asp:Label ID="lbldersAdi" runat="server" Text="Label"><div style="padding-bottom:10px">Sicil Numaranız</div></asp:Label>
                <asp:TextBox ID="txtSicil" runat="server" CssClass="form-control" placeholder="Sicil Numaranızı Giriniz " required></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>

            <div style="position:absolute;top:117px; left:7px; width:670px">
              <asp:Label ID="Label2" runat="server" Text="Label"><div style="padding-bottom:10px">Bölüm Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drpbolum" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="drpbolum_SelectedIndexChanged"  runat="server"  Width="679px" >            
                </asp:DropDownList>
                </div>

            <div style="position:absolute;top:218px; left:7px; width:670px">
              <asp:Label ID="Label1" runat="server" Text="Label"><div style="padding-bottom:10px">Dönem Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drp_donem" class="form-control" runat="server"  Width="679px" >
                    </asp:DropDownList>
                </div>

            <div style="position:absolute;top:315px; left:7px; width:670px">
              <asp:Label ID="Label3" runat="server" Text="Label"><div style="padding-bottom:10px">Yarıyıl Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drpyariyil" class="form-control" runat="server"  Width="679px" >

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

            <div style="position:absolute;top:408px; left:7px; width:670px">
              <asp:Label ID="Label4" runat="server" Text="Label"><div style="padding-bottom:10px">Ders Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drpdersliste" class="form-control" runat="server"  Width="679px" >

                    </asp:DropDownList>
                </div>
             <div  style="position:absolute; top: 501px; left: 7px; ">
               <asp:Button ID="btnkaydet_ders" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="btnkaydet_ders_Click" />
             </div>
            </div>
           </div>
       
    
</asp:Content>

