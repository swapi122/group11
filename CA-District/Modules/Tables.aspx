<%@ Page Language="C#" MasterPageFile="~/MasterPage-1col.master" AutoEventWireup="true" CodeFile="Tables.aspx.cs" Inherits="Modules_Tables" Title="Untitled Page" %>

<%@ Register src="../Controls/Tables.ascx" tagname="Tables" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentHolder" Runat="Server">
    <uc1:Tables ID="Tables1" runat="server" />
</asp:Content>

