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

public partial class Controls_Tables : System.Web.UI.UserControl
{
    public string tableName
    {
        get { return Request["t"]; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadCombo();
            loadData();
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

    void loadData()
    {
        if (!string.IsNullOrEmpty(tableName))
        {
            FTableSchema table = new FTableSchema(tableName, SqlHelper.ConnectionString);
            reptables.DataSource = table.Schema;
            reptables.DataBind();
        }
    }

    protected void reptables_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        EField field = (EField)e.Item.DataItem;

        DropDownList ddlKey = (DropDownList)e.Item.FindControl("ddlKey");
        ddlKey.SelectedValue = field.FieldType;

        DropDownList ddlControl = (DropDownList)e.Item.FindControl("ddlControl");
        ddlControl.SelectedValue = field.Control;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            List<EField> fields = new List<EField>();
            for (int i = 0; i < reptables.Items.Count; i++)
            {
                EField f = new EField();
                f.Title = ((TextBox)reptables.Items[i].FindControl("txtTitle")).Text.Trim();
                f.FieldType = ((DropDownList)reptables.Items[i].FindControl("ddlKey")).SelectedValue;
                f.IsShow = ((CheckBox)reptables.Items[i].FindControl("chkIsShow")).Checked;
                f.IsNull = ((CheckBox)reptables.Items[i].FindControl("chkIsNull")).Checked;
                f.Control = ((DropDownList)reptables.Items[i].FindControl("ddlControl")).SelectedValue;
                f.MaxLength = int.Parse(((TextBox)reptables.Items[i].FindControl("txtMaxLength")).Text.Trim());
                f.Width = Unit.Parse(((TextBox)reptables.Items[i].FindControl("txtWidth")).Text.Trim());
                f.ColumnId = FGuid.ToGuid(((TextBox)reptables.Items[i].FindControl("txtColumnId")).Text.Trim());
                f.ColumnName = ((HiddenField)reptables.Items[i].FindControl("hidColumnName")).Value;
                fields.Add(f);
            }
            FTableSchema.Update(tableName, fields, SqlHelper.ConnectionString);

            Response.Redirect(Request.RawUrl);
        }
    }
}
