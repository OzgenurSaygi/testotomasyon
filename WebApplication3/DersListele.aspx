<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DersListele.aspx.cs" Inherits="WebApplication3.DersListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            left: 11px;
            top: 46px;
            width: 339px;
        }
        .auto-style4 {
        width: 300px;
    }
        .auto-style5 {
            position: absolute;
            left: 8px;
            top: 111px;
            width: 1061px;
            height: 481px;
            margin-left: 0px;
            overflow:scroll;
        }
    .auto-style6 {
        position: absolute;
        left: 374px;
        top: 43px;
    }
        .auto-style15 {
            width: 126px;
            height: 22px;
        }
        .auto-style16 {
            width: 176px;
            height: 22px;
        }
        .auto-style20 {
            width: 215px;
            height: 22px;
        }
        .auto-style21 {
            width: 261px;
            height: 22px;
        }
        .auto-style26 {
            width: 191px;
            height: 22px;
        }
        .auto-style27 {
            width: 270px;
            height: 22px;
        }
        .auto-style29 {
            width: 231px;
            height: 22px;
        }
        
        .auto-style31 {
            width: 350px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
        <div class="form-group was-validated">
            
     <div class="auto-style1">
                <asp:textbox ID="derslisteara" runat="server" CssClass="form-control" placeholder="Bölüm Adını Giriniz"></asp:textbox>
     </div>
     
    <div class="auto-style6">
         <asp:button ID="btnara" runat="server"  text="ARA" CssClass="btn btn-primary" OnClick="btnara_Click" />
    </div>
            <div class="auto-style5">
                <table class="table table-bordered table-hover w-auto" style="margin-left: 0px;">
                    <tr>
                        <th class="auto-style27">DERS KODU</th>
                        <th class="auto-style20">BÖLÜM ADI</th>
                        <th class="auto-style21">ÖĞRETİM YILI</th>
                        <th class="auto-style15">YARIYIL</th>
                        <th class="auto-style16">DERS ADI</th>
                        <th class="auto-style29">ÖĞRENME ÇIKTISI ID</th>
                        <th class="auto-style26">ÖĞRENME ÇIKTISI</th>
                        <th class="auto-style31">İŞLEMLER</th>
                    </tr>
                    <tbody>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                        <tr>
                           <td><%#Eval("ders_kodu") %></td>
                           <td><%#Eval("bolum_adi") %></td>
                           <td><%#Eval("ogretim_yili") %></td>
                           <td><%#Eval("yariyil") %></td>
                           <td><%#Eval("ders_adi") %></td>
                           <td><%#Eval("ogr_cikti_id") %></td>
                           <td><%#Eval("ogrenim_ciktisi") %></td>
                           <td class="auto-style4">
                                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn  btn-danger" NavigateUrl='<%#"~/DersGuncelle.Aspx?derskodu="+Eval("ders_kodu")+"&"+"bolumadi="+Eval("bolum_adi")+"&"+"dersadi="+Eval("ders_adi")+"&"+"ogretimyili="+Eval("ogretim_yili")+"&"+"yariyil="+Eval("yariyil")+"&"+"ogrciktiid="+Eval("ogr_cikti_id")+"&"+"ogrcikti="+Eval("ogrenim_ciktisi") %>'>GÜNCELLE</asp:HyperLink>
                                <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl='<%#"~/DersleriSil.Aspx?derskodu="+Eval("ders_kodu")+"&"+"dersadi="+Eval("ders_adi") %>'>SİL</asp:HyperLink>
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
