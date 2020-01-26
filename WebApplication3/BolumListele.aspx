<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BolumListele.aspx.cs" Inherits="WebApplication3.BolumListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            left: 8px;
            top: 17px;
            width: 339px;
        }
        .auto-style4 {
        width: 179px;
    }
        .auto-style5 {
            position: absolute;
            left: 6px;
            top: 61px;
            width: 779px;
            height: 444px;
            overflow:scroll;
        }
    .auto-style6 {
        position: absolute;
        left: 376px;
        top: 12px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
        <div class="form-group was-validated">
            
     <div class="auto-style1">
                <asp:textbox ID="bolara" runat="server" CssClass="form-control" placeholder="Bölüm Veya Fakülte Adını Arayınız"></asp:textbox>
     </div>
    <div class="auto-style6">
         <asp:button ID="btnara" runat="server"  text="ARA" CssClass="btn btn-primary" OnClick="btnara_Click" />
    </div>
            <div class="auto-style5">
                <table class="table table-bordered table-hover">
                    <tr>
                       
                        <th>BOLUM ID</th>
                        <th>FAKÜLTE</th>
                        <th>BOLUM</th>
                        <th>KAZANIM ID</th>
                        <th>Kazanım Adı</th>
                        <th class="auto-style4">İŞLEMLER</th>
                    </tr>
                    <tbody>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <tr>
                                     
                                     <td><%#Eval("bolum_id") %></td>
                                     <td><%#Eval("fakulte_adi") %></td>
                                     <td><%#Eval("bolum_adi") %></td>
                                     <td><%#Eval("kazanim_id") %></td>
                                     <td><%#Eval("kazanim_adi") %></td>
                                    <td class="auto-style4">
                                     <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn  btn-danger" NavigateUrl='<%#"~/BolumGuncelle.aspx?bolum_id="+Eval("bolum_id")+"&"+"kazanim_id="+Eval("kazanim_id") %>'>GÜNCELLE</asp:HyperLink>
                                    <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl='<%#"~/BolumSil.aspx?bolum_id="+Eval("bolum_id")+"&"+"bolum_adi="+Eval("bolum_adi") %>'>SİL</asp:HyperLink>
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
