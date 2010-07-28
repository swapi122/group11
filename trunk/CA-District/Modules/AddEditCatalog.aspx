<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" CodeFile="AddEditCatalog.aspx.cs" Inherits="Modules_AddEditCatalog" Title="Untitled Page" %>

<%@ Register src="../Controls/AddEditCatalog.ascx" tagname="AddEditCatalog" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentHolder" Runat="Server">
    <uc1:AddEditCatalog ID="AddEditCatalog1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="rightHolder" Runat="Server">
</asp:Content>

