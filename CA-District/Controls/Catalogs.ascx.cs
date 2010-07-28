using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using WB.Library;
using WB.Library.TableSchema;
using System.Collections.Generic;

public partial class Controls_Catalogs : System.Web.UI.UserControl
{
    public string tableName
    {
        get { return Request["t"]; }
    }

    public FTableSchema table;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadHeader();
            loadData();
            loadCombo();
        }
    }

    void loadHeader()
    {
        // Lay danh sach cac column
        if (!string.IsNullOrEmpty(tableName))
        {
            table = new FTableSchema(tableName, SqlHelper.ConnectionString);
            reptables.DataSource = table.Schema;
            reptables.DataBind();

            lblTitle.Text = table.GetTitle();
        }
    }

    void loadData()
    {
        if (!string.IsNullOrEmpty(tableName) && table != null)
        {
            DataTable tbl = table.GetDataAll();
            repRows.DataSource = tbl;
            repRows.DataBind();
        }
    }

    void loadCombo()
    {
        ddlTable.DataTextField = "TableTitle";
        ddlTable.DataValueField = "TableName";
        ddlTable.DataSource = FTableSchema.GetTableNotLevel(SqlHelper.ConnectionString);
        ddlTable.DataBind();

        ddlTable.SelectedValue = tableName;
    }

    public List<string> getRows(object row)
    {
        DataRowView rowview = (DataRowView)row;
        return table.RowToColumn(rowview);
    }

    protected void reptables_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.DataItem != null)
        {
            EField field = (EField)e.Item.DataItem;
            if (!field.IsShow || field.FieldType == ConstraintType.FOREIGN_KEY)
            {
                e.Item.Visible = false;
            }
        }
    }
}
