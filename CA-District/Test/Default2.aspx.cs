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

using System.IO;
using WB.Library;

using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.HelperClasses;

using WB.Library;

public partial class Test_Default2 : System.Web.UI.Page
{
    public Guid a;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            a = 432;
        }
    }

    void btndemo_Click(object sender, EventArgs e)
    {
        string st = "";
        st = "toi yeu " + a.ToString() + " ban";
        st = "toi yeu {0} ban {1}";
        st = string.Format(st, a.ToString(), "");

        ChucNangEntity ob = new ChucNangEntity();
        ob.TenChucNang = Filter.GetMaxString("", ChucNangFields.TenChucNang.MaxLength);
        
    }
}
