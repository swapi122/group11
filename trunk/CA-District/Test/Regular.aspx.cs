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
using System.Text.RegularExpressions;

public partial class Test_Regular : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string st = @"< object width=""3232"" height=""200"" >";
        string pattern = "[\\s]*width=[\"'\\s]([^\"'a-zA-Z#\\s>])+\"[\"'\\s]*";
        //Response.Write(FilterRegular.RegularReplace(TextBox1.Text, TextBox2.Text, TextBox3.Text) + "aa");
        Response.Write(Regex.Replace(st, pattern, TextBox3.Text, RegexOptions.IgnorePatternWhitespace) + " bb");
    }
}
