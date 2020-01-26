<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DersAtamalariListele.aspx.cs" Inherits="WebApplication3.DersAtamalariListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style1 {
            position: absolute;
            left: 8px;
            top: 30px;
            width: 339px;
        }
        .auto-style4 {
        width: 179px;
    }
        .auto-style5 {
            position: absolute;
            left: 6px;
            top: 91px;
            width: 787px;
            height: 370px;
            overflow:scroll;
        }
    .auto-style6 {
        position: absolute;
        left: 372px;
        top: 28px;
    }
         </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script runat="server">
      
        
    </script>
       <div class="container">
        <div class="form-group was-validated">
           
     <div class="auto-style1">
                <asp:textbox ID="dersatamaara" runat="server" CssClass="form-control" placeholder="Sicil No Giriniz"></asp:textbox>
     </div>
    <div class="auto-style6">
         <asp:button ID="btnara" runat="server"  text="ARA" CssClass="btn btn-primary" OnClick="btnara_Click" />
    </div>
            <div class="auto-style5">
                <table class="table table-bordered table-hover">
                    <tr>
                        <th>ID</th>
                        <th>SİCİL NO</th>
                        <th>ADI</th>
                        <th>BOLUM</th>
                        <th>DERS</th>
                        <th>DÖNEM</th>
                        <th>YARIYIL</th>
                        <th class="auto-style4">İŞLEMLER</th>
                    </tr>
                    <tbody>
                       <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("ders_atama_id")%></td>
                                         <td><%#Eval("sicil_no")%></td>
                                          <td><%# Eval("adi")%></td>
                                          <td><%# Eval("bolum_adi")%></td>
                                          <td><%# Eval("ders_adi")%></td>
                                          <td><%# Eval("ogretim_yili")%></td>
                                          <td><%# Eval("yariyil")%></td>
                                        <td class="auto-style4">
                                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn  btn-danger" NavigateUrl='<%#"~/DersAtaGuncelle.Aspx?adi="+Eval("adi")+"&"+"bolumadi="+Eval("bolum_adi")+"&"+"dersadi="+Eval("ders_adi")+"&"+"ogretimyili="+Eval("ogretim_yili")+"&"+"yariyil="+Eval("yariyil")+"&"+"sicilno="+Eval("sicil_no")+"&"+"dersataid="+Eval("ders_atama_id") %>'>GÜNCELLE</asp:HyperLink>
                                        <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl='<% #"~/DersAtamalariSil.Aspx?ders_atama_id="+Eval("ders_atama_id")+"&"+"sicilno="+Eval("sicil_no")+"&"+"adi="+Eval("adi")+"&"+"dersadi="+Eval("ders_adi")%>'>SİL</asp:HyperLink>
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
