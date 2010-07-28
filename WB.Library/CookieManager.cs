using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;

namespace WB.Library
{
    public class CookieManager
    {
        public static void setCookie(Page page, string key, string value)
        {
            HttpCookie cookie = new HttpCookie(key, value);
            cookie.Path = "/";
            page.Response.SetCookie(cookie);
        }

        public static string getCookie(Page page, string key)
        {
            HttpCookie cookie = page.Request.Cookies[key];
            if (cookie != null)
                return cookie.Value;
            return string.Empty;
        }

        public static void deleteCookie(Page page, string key)
        {
            HttpCookie cookie = page.Request.Cookies[key];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-10);
                page.Response.SetCookie(cookie);
            }
        }
    }
}
