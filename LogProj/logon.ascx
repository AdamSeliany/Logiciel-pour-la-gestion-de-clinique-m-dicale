<%@ Control Language="VB" CodeBehind="logon.ascx.vb" ClassName="logon" Inherits="logon"%>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v20.2, Version=20.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.ExpressApp.Web.Templates.ActionContainers"
    TagPrefix="xaf" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v20.2, Version=20.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.ExpressApp.Web.Templates.Controls"
    TagPrefix="xaf" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v20.2, Version=20.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.ExpressApp.Web.Controls"
    TagPrefix="xaf" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v20.2, Version=20.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.ExpressApp.Web.Templates"
    TagPrefix="xaf" %>
<xaf:XafUpdatePanel ID="UPPopupWindowControl" runat="server">
    <xaf:XafPopupWindowControl runat="server" ID="PopupWindowControl" />
</xaf:XafUpdatePanel>
<xaf:XafUpdatePanel ID="UPHeader" runat="server">
    <div class="Header">
        <table cellpadding="0" cellspacing="0" border="0">
            <tr>
                <td class="ViewImage">
                    <xaf:ViewImageControl ID="VIC" runat="server" />
                </td>
                <td class="ViewCaption">
                    <h1>
                        <xaf:ViewCaptionControl ID="VCC" DetailViewCaptionMode="ViewCaption"
                            runat="server" />
                    </h1>
                </td>
            </tr>
        </table>
    </div>
</xaf:XafUpdatePanel>
<table class="DialogContent Content LogonContent" border="0" cellpadding="0" cellspacing="0"
    width="100%">
    <tr>
        <td class="LogonContentCell" align="center">
            <xaf:XafUpdatePanel ID="UPEI" runat="server">
                <xaf:ErrorInfoControl ID="ErrorInfo" Style="margin: 10px 0px 10px 0px" runat="server" />
            </xaf:XafUpdatePanel>
            <asp:Table ID="Table1" CssClass="Logon" runat="server" BorderWidth="0px" CellPadding="0"
                CellSpacing="0">
                <asp:TableRow ID="TableRow2" runat="server">
                    <asp:TableCell runat="server" ID="ViewSite">
                        <xaf:XafUpdatePanel ID="UPVSC" runat="server">
                            <xaf:ViewSiteControl ID="VSC" runat="server" />
                        </xaf:XafUpdatePanel>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="TableRow3" runat="server">
                    <asp:TableCell runat="server" ID="TableCell4" HorizontalAlign="Right" Style="padding: 20px 0px 20px 0px">
                        <xaf:XafUpdatePanel ID="UPPopupActions" runat="server">
                            <xaf:ActionContainerHolder ID="PopupActions" runat="server"
                                Style="margin-left: 10px; display: inline" Orientation="Horizontal" ContainerStyle="Buttons">
                                <Menu Width="100%" ItemAutoWidth="False" HorizontalAlign="Right" />
                                <ActionContainers>
                                    <xaf:WebActionContainer ContainerId="PopupActions" IsDropDown="false" />                                                
                                </ActionContainers>                             
                            </xaf:ActionContainerHolder>
                        </xaf:XafUpdatePanel>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </td>
    </tr>
</table>
