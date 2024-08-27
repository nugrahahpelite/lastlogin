<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="lastlogin._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <form id="form1" runat="server">
    <div>
        <%-- <asp:ScriptManager ID="ScriptManager1" runat="server"> 
                             </asp:ScriptManager> --%>
        <asp:UpdatePanel ID="UpnLogin" runat="server">
        <ContentTemplate>
            <table class="myPanelGreyLight" style="position:absolute;top:21%; left:2%; background-color:#F2F2F2;font-family:Tahoma;font-size:12px; height: 329px; width: 941px;">
                <tr><td colspan="4" style="font-size:15px">
                    <table>
                        <tr>
                            <td rowspan="2"></td>                    
                            <td class="auto-style3"><p class="site-title" style="font-variant: normal; font-style: italic ; font-weight: 500; font-size: xx-large ; text-transform: capitalize;"></p>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Document</td>
                        </tr>
                    </table>
                    </td>
                </tr>
                <tr><td style="height: 25px;"><strong>User ID</strong></td>
                    <td>:&nbsp;&nbsp;&nbsp; </td>
                    <td style="width:113px" class="auto-style2">
                        <asp:TextBox ID="TxtUserID" runat="server" Font-Names="Tahoma" Font-Size="12px"></asp:TextBox>
                    </td>
                    <td class="auto-style1" style="width: 260px">                        
                    </td>
                </tr>
                <tr><td style="height: 25px;">Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td>:</td>
                    <td style="width: 113px" class="auto-style2">
                        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" Font-Names="Tahoma" Font-Size="12px">bnsrps</asp:TextBox>                
                    </td>
                    <td class="auto-style1" style="width: 260px"><asp:Label ID="LblMessage" runat="server" ForeColor="Red" Text="Message" Visible="False"></asp:Label></td>
                </tr>
                <tr>
                    <td style="height: 23px"></td>
                    <td style="height: 23px"></td>
                    <td style="height: 23px" colspan="2"><asp:Label ID="LblMessageSessionEnd" runat="server" ForeColor="Red" Text="SESSION ANDA SUDAH BERAKHIR. HARAP LOGIN ULANG" Visible="False"></asp:Label></td>
                </tr>
                <tr><td>
                    &nbsp;</td>
                    <td>&nbsp;</td>
                    <td style="width: 113px" class="auto-style2">
                        <asp:Button ID="BtnLogin" CssClass="myButtonAct" runat="server" Text="Login" Width="116px" Height="40.5px" Font-Names="Tahoma" Font-Size="12px" />
                    </td>
                </tr>
            </table>
        </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</asp:Content>
