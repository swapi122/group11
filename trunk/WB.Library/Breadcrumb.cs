using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using System.Collections.Generic;

/// <summary>
/// Summary description for Breadcrumb
/// </summary>
namespace WB.Library
{
    public class LinkEntity
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Alt { get; set; }
        public bool Last { get; set; }
    }

    public class Breadcrumb
    {
        MasterPage _masterpage;
        Page _page = new Page();
        Control _control;
        int _levelMasterPage = 2;
        string _controlId = "ucMyBreadcrumb";

        List<LinkEntity> _link = new List<LinkEntity>();
        
        public Breadcrumb(Page page)
        {
            _page = page;
        }

        /// <summary>
        /// Khởi tạo Breadcrumb
        /// </summary>
        /// <param name="levelMasterPage">Cấp của master page chính</param>
        /// <param name="controlId">Tên của control Breadcrumb tren main master page</param>
        public void Init(int levelMasterPage, string controlId)
        {
            _levelMasterPage = levelMasterPage;
            _controlId = controlId;
            _masterpage = _page.Master;

            if (_masterpage == null)
                return;

            for (int i = 1; i <= levelMasterPage - 1; i++)
                _masterpage = _masterpage.Master as MasterPage;
            _control = _masterpage.FindControl(controlId);
        }

        /// <summary>
        /// Khởi tạo Breadcrumb
        /// </summary>
        /// <param name="levelMasterPage">Cấp của master page chính</param>
        public void Init(int levelMasterPage)
        {
            _levelMasterPage = levelMasterPage;
            Init(levelMasterPage, _controlId);
        }

        /// <summary>
        /// Khởi tạo Breadcrumb
        /// </summary>
        public void Init()
        {
            for (int i = 1; i <= 10; i++)
            {
                _levelMasterPage = i;
                Init(_levelMasterPage, _controlId);
                if (_control != null)
                    break;
            }
        }

        /// <summary>
        /// Add navigation vào breadcrumb
        /// </summary>
        /// <param name="title">Title của link</param>
        /// <param name="link">Href của navigation</param>
        public void Add(string title, string link)
        {
            Add(title, link, title, false);
        }

        /// <summary>
        /// Add navigation vào breadcrumb
        /// </summary>
        /// <param name="title">Title của link</param>
        /// <param name="link">Href của navigation</param>
        /// <param name="alt">Alt của link</param>
        public void Add(string title, string link, string alt)
        {
            Add(title, link, alt, false);
        }

        /// <summary>
        /// Add navigation vào breadcrumb
        /// </summary>
        /// <param name="title">Title của link</param>
        /// <param name="link">Href của navigation</param>
        /// <param name="alt">Alt của link</param>
        /// <param name="last">Nếu link cuối cùng chỉ là text thì truyền vào là true</param>
        public void Add(string title, string link, string alt, bool last)
        {
            LinkEntity item = new LinkEntity();
            item.Title = title;
            item.Link = link;
            item.Alt = alt;
            item.Last = last;
            _link.Add(item);
        }

        /// <summary>
        /// Add navigation text cuối cùng vào breadcrumb
        /// </summary>
        /// <param name="title"></param>
        public void Add(string title)
        {
            Add(title, "", "", true);
        }

        /// <summary>
        /// Bắt đầu tạo breadcrumb
        /// </summary>
        /// <param name="titleHome">Gán title cho link đầu tiên</param>
        /// <param name="linkHome">Gán href cho link đầu tiên</param>
        /// <param name="alt">Gán alt cho link đầu tiên</param>
        public void StartBreadcrumb(string titleHome, string linkHome, string alt)
        {
            LinkEntity item = new LinkEntity();
            item.Title = titleHome;
            item.Link = linkHome;
            item.Alt = alt;
            item.Last = false;
            _link.Insert(0, item);
           Repeater rpt = (Repeater)_control.FindControl("rptLink");
            rpt.DataSource = _link;
            rpt.DataBind();
        }

        /// <summary>
        /// Bắt đầu tạo breadcrumb, link đầu tiên là link trang chủ
        /// </summary>
        public void StartBreadcrumb()
        {
            LinkEntity item = new LinkEntity();
            item.Title = "Trang chủ";
            item.Link = UrlBuilder.RootUrl;
            item.Alt = "MP_Portal";
            item.Last = false;
            _link.Insert(0, item);

            Repeater rpt = (Repeater)_control.FindControl("rptLink");
            rpt.DataSource = _link;
            rpt.DataBind();
        }
    }
}