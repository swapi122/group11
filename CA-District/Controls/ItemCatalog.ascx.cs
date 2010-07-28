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

public partial class Controls_ItemCatalog : System.Web.UI.UserControl
{
    public EField field
    {
        set
        {
            ViewState["field.ColumnName"] = value.ColumnName;
            ViewState["field.SDataType"] = value.SDataType;
            ViewState["field.FieldType"] = value.FieldType;
            ViewState["field.IsNull"] = value.IsNull;
            ViewState["field.IsShow"] = value.IsShow;
            ViewState["field.MaxLength"] = value.MaxLength;
            ViewState["field.SqlDataType"] = value.SqlDataType;
            ViewState["field.Title"] = value.Title;
            ViewState["field.Control"] = value.Control;
            ViewState["field.Width"] = value.Width;
            ViewState["field.UControl"] = value.UControl;
            ViewState["field.ColumnId"] = value.ColumnId;
        }
        get
        {
            EField f = new EField();
            if (ViewState["field.ColumnName"] != null)
            {
                f.ColumnName = ViewState["field.ColumnName"].ToString();
                f.SDataType = ViewState["field.SDataType"].ToString();
                f.FieldType = ViewState["field.FieldType"].ToString();
                f.IsNull = (bool)ViewState["field.IsNull"];
                f.IsShow = (bool)ViewState["field.IsShow"];
                f.MaxLength = (int)ViewState["field.MaxLength"];
                f.SqlDataType = ViewState["field.SqlDataType"].ToString();
                f.Title = ViewState["field.Title"].ToString();
                f.Control = ViewState["field.Control"].ToString();
                f.Width = Unit.Parse(ViewState["field.Width"].ToString());
                f.UControl = ViewState["field.UControl"].ToString();
                f.ColumnId = FGuid.ToGuid(ViewState["field.ColumnId"]);
            }
            return f;
        }
    }

    public DataTable data
    {
        set { ViewState["data"] = value; }
        get { return ViewState["data"] != null ? (DataTable)ViewState["data"] : null; }
    }

    void loadConstructor()
    {
        string type = "";
        string css = "";
        EField tmp = field;

        switch (field.Control)
        {
            case EControl.Input:
                css = "";
                type = "textbox";
                break;
            case EControl.Area:
                type = "textbox";
                break;
            case EControl.Email:
                css = "";
                type = "textbox";
                regtxt.Enabled = true;
                regtxt.ErrorMessage = "Địa chỉ email chưa hợp lệ";
                break;
            case EControl.Date:
                css = "date";
                type = "textbox";
                break;
            case EControl.DateTime:
                css = "datetime";
                type = "textbox";
                break;
            case EControl.Numric:
                type = "textbox";
                break;
            case EControl.FileUpload:
                type = "fileupload";
                break;
            case EControl.Combobox:
                type = "select";
                break;
        }

        switch (type)
        {
            case "textbox":
                valtxt.Visible = !field.IsNull;

                valtxt.ErrorMessage = "Nhập " + field.Title;
                divTextbox.Visible = true;
                txtField.Text = "txtItem";
                txtField.Attributes.Add("Control", type);

                txtItem.Width = field.Width;
                txtItem.CssClass = css;

                tmp.UControl = UIControl.UTextbox;
                break;
            case "fileupload":
                divFileUpload.Visible = true;

                txtField.Text = "uploadItem";
                txtField.Attributes.Add("Control", type);
                tmp.UControl = UIControl.UFileUpload;
                break;
            case "select":
                divDropdownlist.Visible = true;
                valddl.Visible = !field.IsNull;
                valddl.ErrorMessage = "Chọn " + field.Title;
                txtField.Text = "ddlItem";
                tmp.UControl = UIControl.UDropDownlist;

                ddlItem.Width = field.Width;
                string columnForeign = "";
                DataTable tbl = FTableSchema.GetDataForeign(field, SqlHelper.ConnectionString, out columnForeign);
                ddlItem.DataTextField = columnForeign;
                ddlItem.DataValueField = "Id";
                ddlItem.DataSource = tbl;
                ddlItem.DataBind();
                break;
        }
        field = tmp;
        txtField.Attributes.Add("SDateType", field.SDataType);
    }

    void loadData()
    {
        if (data != null)
        {
            switch (field.UControl)
            {
                case UIControl.UTextbox:
                    switch (field.SDataType)
                    {
                        case DataType.String:
                            txtItem.Text = data.Rows[0][field.ColumnName].ToString();
                            break;
                        case DataType.Int:
                            txtItem.Text = data.Rows[0][field.ColumnName].ToString();
                            break;
                        case DataType.Double:
                            txtItem.Text = FNumber.FormatNumber(data.Rows[0][field.ColumnName], 2);
                            break;
                        case DataType.DateTime:
                            txtItem.Text = FDateTime.FormatDate(Convert.ToDateTime(data.Rows[0][field.ColumnName]));
                            break;
                    }
                    break;
                case UIControl.UFileUpload:
                    break;
                case UIControl.UDropDownlist:
                    ddlItem.SelectedValue = data.Rows[0][field.ColumnName].ToString();
                    break;
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!(field.IsShow))
            {
                this.Visible = false;
                return;
            }

            loadConstructor();
            loadData();
        }
    }
}
