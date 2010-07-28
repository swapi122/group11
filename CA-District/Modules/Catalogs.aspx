<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" CodeFile="Catalogs.aspx.cs" Inherits="Modules_Catalogs" Title="Untitled Page" %>

<%@ Register src="../Controls/Catalogs.ascx" tagname="Catalogs" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentHolder" Runat="Server">
    <uc1:Catalogs ID="Catalogs1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="rightHolder" Runat="Server">
</asp:Content>

