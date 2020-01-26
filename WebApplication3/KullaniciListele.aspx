<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="KullaniciListele.aspx.cs" Inherits="WebApplication3.KullaniciListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            left: 15px;
            top: 3px;
            width: 505px;
        }
        .auto-style2 {
            position: absolute;
            left: 529px;
            top: 1px;
        }
        .auto-style3 {
            position: absolute;
            left: 16px;
            top: 36px;
            width: 677px;
            margin-top: 25px;
            overflow:scroll;
        }
    .auto-style4 {
        width:300px;
    }
        .auto-style5 {
            width: 199px;
        }
        .auto-style6 {
            width: 130px;
        }
        .auto-style7 {
            width: 99px;
        }
        .auto-style8 {
            width: 79px;
        }
        .auto-style9 {
            width: 82px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
        <div class="form-group was-validated">
            <div class="auto-style1">
                <asp:textbox ID="kulara" runat="server" CssClass="form-control" placeholder="Aramak istediğiniz öğretim elemanının sicil no giriniz"></asp:textbox>
            </div>
            <div class="auto-style2">
                <asp:button ID="btnara" runat="server"  text="ARA" CssClass="btn btn-primary" OnClick="btnara_Click" />
            </div>
            <div class="auto-style3">
                <table class="table table-bordered table-hover">
                    <tr>
                        <th class="auto-style6">Sicil NO</th>
                        <th class="auto-style7">AD</th>
                        <th class="auto-style8">SOYAD</th>
                        <th class="auto-style9">ŞİFRE</th>
                        <th class="auto-style5">KULLANICI TÜR</th>
                        <th class="auto-style4">İŞLEMLER</th>
                        
                    </tr>
                    <tbody>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("sicil_no")%></td>
                                    <td><%# Eval("adi")%></td>
                                    <td><%# Eval("soyadi")%></td>
                                   <td><%# Eval("sifre")%></td>
                                    <td><%#Eval("kullanici_tur_adi") %></td>
                                    <td class="auto-style4">
                                     <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn  btn-danger" NavigateUrl='<%#"~/KullaniciGuncelle.aspx?sicil_no="+Eval("sicil_no") %>'>GÜNCELLE</asp:HyperLink>
                                    <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl='<%#"~/KullaniciSil.aspx?sicil_no="+Eval("sicil_no")+"&"+"adi="+Eval("adi")+"&"+"soyadi="+Eval("soyadi") %>'>SİL</asp:HyperLink>
                                   </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
           </div>
           </div>
           
</asp:Content>
