<%@ Page Title="" Language="C#" MasterPageFile="~/Company/CSL.Master" AutoEventWireup="true" Inherits="SuperiorWeb.CSL.CompanyInfo" Codebehind="CompanyInfo.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DisplayHeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="subTabNavigation" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    <div id="content">
        <div class="w1000 center">
            <div class="contentPage">
                <div class="rightColumn">
                    <h2 class="tg hr">
                        <asp:Literal ID="ltTitle" runat="server">
                        </asp:Literal>
                    </h2>
                </div>
                <div class="section">
                    <asp:Literal ID="ltContent" runat="server"></asp:Literal>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
