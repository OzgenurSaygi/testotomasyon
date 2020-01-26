<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="KazanimAdminListe.aspx.cs" Inherits="WebApplication3.KazanimAdminListe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            left: 727px;
            top: 305px;
        }
        .auto-style2 {
            position: absolute;
            top: 412px;
            left: 12px;
            height: 172px;
            width: 554px;
        }
        .auto-style3 {
            position: absolute;
            top: 358px;
            left: 11px;
            width: 628px;
        }
        .auto-style4 {
            position: absolute;
            left: 363px;
            top: 414px;
            width: 407px;
        }
        .auto-style5 {
            position: absolute;
            left: 697px;
            top: 414px;
            width: 398px;
        }
        .auto-style6 {
            position: absolute;
            left: 16px;
            top: 264px;
            width: 188px;
        }
        .auto-style7 {
            position: absolute;
            left: 15px;
            top: 306px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
        <div class="form-group was-validated">

               <div style="position:absolute;top:10px; left:13px; width:670px">
              <asp:Label ID="Label2" runat="server" Text="Label"><div style="padding-bottom:10px">Bölüm Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drpbolum" AutoPostBack="true" class="form-control" runat="server"  Width="679px" >
                </asp:DropDownList>
                </div>
             <div style="position:absolute;top:90px; left:13px; width:670px">
              <asp:Label ID="Label1" runat="server" Text="Label"><div style="padding-bottom:10px">Dönem Seçiniz</div></asp:Label>
                <asp:DropDownList ID="drp_donem" AutoPostBack="true" class="form-control" runat="server"  Width="679px" >
                    </asp:DropDownList>
                 </div>
                  <div style="position:absolute;top:180px; left:13px; width:670px">
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
            <div class="auto-style3">
                <asp:Label ID="lblbaslik" runat="server" Text=""></asp:Label>

            </div>
            <div class="auto-style2">
                <table class="table table-bordered table-hover w-auto" style="margin-left: 0px;">
                     <tr>
                        <th class="auto-style27">DERS ADI</th>
                        <th class="auto-style20">VİZELER</th>
                     </tr>
                    <tbody>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <tr>
                                <td><%#Eval("ders_adi")%></td>
                                <td><asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl='<%#"kazanimsonuc/"+Eval("kazanim_path")%>'>Vize</asp:HyperLink></td>
                                </tr>
                             </ItemTemplate>
                            </asp:Repeater>
                   </tbody>
                </table>
            </div>
             <div class="auto-style4" >
                <table class="table table-bordered table-hover w-auto" style="margin-left: 0px;">
                     <tr>
                        <th class="auto-style27">DERS ADI</th>
                        <th class="auto-style20">FİNALLER</th>
                     </tr>
                    <tbody>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <tr>
                                <td><%#Eval("ders_adi")%></td>
                                <td><asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl='<%#"kazanimsonuc/"+Eval("kazanim_path")%>'>Final</asp:HyperLink></td>
                                </tr>
                             </ItemTemplate>
                            </asp:Repeater>
                   </tbody>
                </table>
            </div>
            <div class="auto-style5" >
                <table class="table table-bordered table-hover w-auto" style="margin-left: 0px; width: 165px;">
                     <tr>
                        <th class="auto-style27">DERS ADI</th>
                        <th class="auto-style20">BÜTÜNLEMELER</th>
                     </tr>
                    <tbody>
                        <asp:Repeater ID="Repeater3" runat="server">
                            <ItemTemplate>
                                <tr>
                                <td><%#Eval("ders_adi")%></td>
                                <td><asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl='<%#"kazanimsonuc/"+Eval("kazanim_path")%>'>Bütünleme</asp:HyperLink></td>
                                </tr>
                             </ItemTemplate>
                            </asp:Repeater>
                   </tbody>
                </table>
            </div>
            <div class="auto-style1">
                <asp:Button ID="btngetir" CssClass="btn btn-primary" runat="server" OnClick="btngetir_Click" Text="Listele" /></div>
             <div class="auto-style6">Sicil No Giriniz</div>
             <div class="auto-style7"><asp:TextBox ID="txtsicil" CssClass="form-control" placeholder="Sicilno giriniz" runat="server" Width="684px"></asp:TextBox></div>
            </div>
           </div>
      
</asp:Content>

