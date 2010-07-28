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

public partial class Controls_AddEditCatalog : System.Web.UI.UserControl
{
    public string tableName
    {
        get { return Request["t"]; }
    }

    public Guid Id
    {
        get { return FGuid.ToGuid(Request["id"]); }
    }

    public FTableSchema ftable;
    public DataTable data
    {
        set { ViewState["data"] = value; }
        get { return ViewState["data"] != null ? (DataTable)ViewState["data"] : null; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadData();
        }
    }

    void loadData()
    {
        if (!string.IsNullOrEmpty(tableName))
        {
            ftable = new FTableSchema(tableName, SqlHelper.ConnectionString);

            if (Id != Guid.Empty)
            {
                data = ftable.GetDataById(Id);
                if (data != null && data.Rows.Count > 0)
                {
                    btnAdd.Visible = false;
                    btnEdit.Visible = true;
                    btnDelete.Visible = true;
                }
            }

            rep.DataSource = ftable.Schema;
            rep.DataBind();

            lblTitle.Text = ftable.GetTitle();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ftable = new FTableSchema(tableName, SqlHelper.ConnectionString);

            for (int i = 0; i < rep.Items.Count; i++)
            {
                Controls_ItemCatalog item = (Controls_ItemCatalog)rep.Items[i].FindControl("item");
                if (item.Visible)
                {
                    TextBox fieldId = (TextBox)item.FindControl("txtField");
                    string value = "";

                    switch (item.field.UControl)
                    {
                        case UIControl.UTextbox:
                            value = ((TextBox)item.FindControl(fieldId.Text)).Text;
                            break;
                        case UIControl.UDropDownlist:
                            value = ((DropDownList)item.FindControl(fieldId.Text)).SelectedValue;
                            break;
                        case UIControl.UFileUpload:
                            break;
                    }

                    ftable.AddParam(item.field, value);
                }
            }
            ftable.Insert();
            Response.Redirect(Request.RawUrl);
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ftable = new FTableSchema(tableName, SqlHelper.ConnectionString);

            for (int i = 0; i < rep.Items.Count; i++)
            {
                Controls_ItemCatalog item = (Controls_ItemCatalog)rep.Items[i].FindControl("item");
                if (item.Visible)
                {
                    TextBox fieldId = (TextBox)item.FindControl("txtField");
                    string value = "";

                    switch (item.field.UControl)
                    {
                        case UIControl.UTextbox:
                            value = ((TextBox)item.FindControl(fieldId.Text)).Text;
                            break;
                        case UIControl.UFileUpload:
                            break;
                        case UIControl.UDropDownlist:
                            value = ((DropDownList)item.FindControl(fieldId.Text)).SelectedValue;
                            break;
                    }

                    ftable.AddParam(item.field, value);
                }
            }
            ftable.Update(Id);
            Response.Redirect(Request.RawUrl);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Modules/Catalogs.aspx?t=" + tableName);
    }

    protected void rep_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        EField field = (EField)e.Item.DataItem;
        Controls_ItemCatalog item = (Controls_ItemCatalog)e.Item.FindControl("item");

        if (data != null && data.Rows.Count > 0)
        {
            item.data = data;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        ftable = new FTableSchema(tableName, SqlHelper.ConnectionString);
        ftable.Delete(Id);
        Response.Redirect("/Modules/Catalogs.aspx?t=" + tableName);
    }
}
