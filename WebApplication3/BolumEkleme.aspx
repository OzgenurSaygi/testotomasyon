<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BolumEkleme.aspx.cs" Inherits="WebApplication3.BolumEkleme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
        <div class="form-group was-validated">
            <div style="position:absolute; top: 13px; left: 10px; width: 679px">
                <asp:Label ID="lblbolumadi" runat="server" Text="Label"><div style="padding-bottom:10px">Bölüm Adı</div></asp:Label>
                <asp:TextBox ID="txtbolumadi" runat="server" CssClass="form-control" placeholder="Bölüm Adı" ></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
            <div style="position:absolute;top:125px; left:11px; width:670px">
              <asp:Label ID="Label1" runat="server" Text="Label"><div style="padding-bottom:10px">Fakülte Adını Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drpfakulteliste" class="form-control" runat="server"  Width="679px">
                </asp:DropDownList>
            </div>
            <div style="position:absolute; top: 414px; left: 9px; width: 560px;">
                <asp:Label ID="Label2" runat="server" Text="Kazanım Ekleyiniz"></asp:Label>
            </div>
            <div style="position:absolute; top: 450px; left: 10px; height: 22px; width: 679px;">
                <asp:TextBox ID="txtkazanim" runat="server" CssClass="form-control" placeholder="Kazanım"></asp:TextBox>
                <div class="valid-feedback">Başarılı</div>
                <div class="invalid-feedback">Lütfen Boş Alanları Doldurunuz</div>
            </div>
            <div style="position:absolute; top: 533px; left: 10px; height: 29px; width: 86px;">
                <asp:Button ID="btnkazanimekle" runat="server" Text="Ekle" CssClass="btn btn-primary" OnClick="btnkazanimekle_Click" Height="37px" Width="75px" />
            </div>
            
            <div  style="position:absolute; top: 224px; left: 12px; ">
               <asp:Button ID="btnkaydet_blm" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="btnkaydet_blm_Click" />
             </div>
            <div style="position:absolute;border-bottom:1px solid black; top: 294px; left: 13px; width: 674px;"></div>
            <div style="position:absolute; top: 366px; left: 11px; width: 679px;">
                <asp:DropDownList ID="drpbolumliste" runat="server" CssClass="form-control" Width="679px"></asp:DropDownList>
            </div>
            <div style="position:absolute; top: 580px; left: 11px; width: 298px; height: 122px;">
                <div style="position:absolute; top: -251px; left: -2px;"><asp:Label ID="lblbolumliste" runat="server" Text="Label"><div style="padding-bottom:10px">Kazanım Ekleyeceğiniz Bölümü Seçiniz</div></asp:Label></div>
                <asp:ListBox ID="ListBox1" runat="server" Height="116px" Width="235px"  ></asp:ListBox>
            </div>
            
            </div>
           </div>
</asp:Content>
