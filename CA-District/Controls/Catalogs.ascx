<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Catalogs.ascx.cs" Inherits="Controls_Catalogs" %>
<h2>
   <asp:Label ID="lblTitle" runat="server">&nbsp;</asp:Label> </h2>
<div class="fmnu">
    <ul>
        <li class="refresh"><a href="<%= Request.RawUrl %>">Đọc dữ liệu</a></li>
        <% if (!string.IsNullOrEmpty(Request["t"]))
           { %>
        <li class="add"><a href='/Modules/AddEditCatalog.aspx?t=<%= Request["t"] %>'>Thêm danh
            mục</a></li>
        <% }%>
    </ul>
</div>
<div style="margin-bottom: 10px;">
    Bảng :
    <asp:DropDownList ID="ddlTable" runat="server" AppendDataBoundItems="true" Width="250px">
        <asp:ListItem Value="">----------------- Chọn bảng -----------------</asp:ListItem>
    </asp:DropDownList>
</div>
<table class="grid">
    <asp:Repeater ID="reptables" runat="server" OnItemDataBound="reptables_ItemDataBound">
        <HeaderTemplate>
            <tr>
        </HeaderTemplate>
        <ItemTemplate>
            <th>
                <%# Eval("Title") %>
            </th>
        </ItemTemplate>
        <FooterTemplate>
            <th width="30px">
            </th>
            </tr>
        </FooterTemplate>
    </asp:Repeater>
    <asp:Repeater ID="repRows" runat="server">
        <ItemTemplate>
            <tr>
                <asp:Repeater ID="repcols" runat="server" DataSource="<%# getRows(Container.DataItem) %>">
                    <ItemTemplate>
                        <%# Container.DataItem %>
                    </ItemTemplate>
                </asp:Repeater>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>

<script type="text/javascript">
    $(document).ready(function(){
        $(".fmnu").fmenu();
        
        $("#<%= ddlTable.ClientID %>").change(function(){
            window.location = "/Modules/Catalogs.aspx?t=" + $(this).val();
        });
    });
</script>

