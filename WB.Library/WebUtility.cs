using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Net;
using System.Web.Services.Protocols;
using System.Configuration;
namespace WB.Library
{
    public class WebUtility
    {
        private static readonly NetworkCredential credential;
        static WebUtility()
        {
            string user = ConfigurationSettings.AppSettings["WEB.SERVICE.USERNAME"];
            string pass = ConfigurationSettings.AppSettings["WEB.SERVICE.PASSWORD"];
            if (user != null && user != "")
            {
                credential = new NetworkCredential(user, pass);
            }
        }
        public static string GetLockButtonJscript(Page p, LinkButton btn, string disabledText, ArrayList aCol, string customScript)
        {
            disabledText = string.IsNullOrEmpty(disabledText) ? btn.Text : disabledText; disabledText = disabledText.Replace("'", "");

            StringBuilder sb = new StringBuilder();
            if (btn.CausesValidation && p.Validators.Count > 0 && btn != null)
            {
                sb.Append("if (typeof(Page_ClientValidate) == 'function') { ");
                sb.Append("if (Page_ClientValidate('" + btn.ValidationGroup + "') == false) { return false; }} ");
            }

            if (!String.IsNullOrEmpty(customScript))
            {
                sb.Append(customScript);
            }

            PostBackOptions opt = new PostBackOptions(btn, "", "", false, true, true, true, true, btn.ValidationGroup);

            sb.Append(p.ClientScript.GetPostBackEventReference(opt));
            sb.Append(";");

            if (String.IsNullOrEmpty(customScript))
            {
                sb.Append("this.style.display='none';this.value='" + disabledText + "';");
            }

            if (aCol != null)
            {
                foreach (Control c in aCol)
                {
                    if (c is LinkButton)
                    {
                        sb.Append("document.getElementById('" + c.ClientID + "').style.display='none';");
                        sb.Append("document.getElementById('" + c.ClientID + "').value='dadasdsadas';");
                    }
                }
            }

            return sb.ToString();
        }

        public static string GetLockButtonJscript(Page p, LinkButton btn, string disabledText, string customScript)
        {
            return GetLockButtonJscript(p, btn, disabledText, null, customScript);
        }

        public static string GetLockButtonJscript(Page p, Button btn, string disabledText, ArrayList aCol, string customScript)
        {
            disabledText = string.IsNullOrEmpty(disabledText) ? btn.Text : disabledText; disabledText = disabledText.Replace("'", "");

            StringBuilder sb = new StringBuilder();
            if (btn.CausesValidation && p.Validators.Count > 0 && btn != null)
            {
                sb.Append("if (typeof(Page_ClientValidate) == 'function') { ");
                sb.Append("if (Page_ClientValidate('" + btn.ValidationGroup + "') == false) { return false; }} ");
            }

            if (!String.IsNullOrEmpty(customScript))
            {
                sb.Append(customScript);
            }

            PostBackOptions opt = new PostBackOptions(btn, "", "", false, true, true, true, true, btn.ValidationGroup);

            sb.Append(p.ClientScript.GetPostBackEventReference(opt));
            sb.Append(";");

            if (String.IsNullOrEmpty(customScript))
            {
                sb.Append("this.disabled='disabled';this.value='" + disabledText + "';");
            }

            if (aCol != null)
            {
                foreach (Control c in aCol)
                {
                    if (c is Button)
                    {
                        sb.Append("document.getElementById('" + c.ClientID + "').disabled='disabled';");
                        sb.Append("document.getElementById('" + c.ClientID + "').value='" + disabledText + "';");
                    }

                }
            }

            return sb.ToString();
        }

        public static string GetLockButtonJscript(Page p, Button btn, string disabledText, string customScript)
        {
            return GetLockButtonJscript(p, btn, disabledText, null, customScript);
        }

        public static void DownLoadFile(Page p, string filename, byte[] buffer)
        {
            p.Response.Clear();
            p.Response.ContentType = "application/octet-stream";
            p.Response.AddHeader("Content-Length", buffer.Length.ToString());
            p.Response.AddHeader("Content-Disposition", "attachment; filename=" + filename);
            p.Response.BinaryWrite(buffer);
            p.Response.End();
        }
        /// <summary>
        /// Download file ve client
        /// </summary>
        /// <param name="p"></param>
        /// <param name="clientName">Ten file mac dinh nguoi dung thay khi download ve</param>
        /// <param name="serverFilePath">Duong dan file tren server</param>
        public static void DownLoadFile(Page p, string clientName, string serverFilePath)
        {
            byte[] buffer = FileUtil.ReadByteArrayFromFile(serverFilePath);
            DownLoadFile(p, clientName, buffer);
        }
        /// <summary>
        /// Get webservice class
        /// </summary>
        /// <param name="url">URL of webservice</param>
        /// <param name="encode">Endcoding</param>
        /// <param name="timeOut">Time out</param>
        /// <param name="type">Type of webservice</param>
        /// <param name="className">Webservice class name</param>
        /// <returns></returns>
        public static SoapHttpClientProtocol GetWebService(
           string url, string encode, string timeOut, Type type, string className)
        {

            Type classType = type.Assembly.GetType(className);

            SoapHttpClientProtocol service = (SoapHttpClientProtocol)
                    Activator.CreateInstance(classType);

            service.Credentials = credential;
            String strUrl = url.Trim('/', '\\', ' ');
            service.Url = strUrl;
            service.Proxy = WebProxy.GetDefaultProxy();
            service.Timeout = int.Parse(timeOut);
            service.RequestEncoding = Encoding.GetEncoding(encode);
            return service;
        }
        /// <summary>
        /// Get Webservice object.
        /// </summary>
        /// <param name="wsAbsolutePath">AbsolutePath of webservice.EX: ManagerService/CitiesService.asmx</param>
        /// <param name="type">Type of webservice in local</param>
        /// <param name="className">Class name of webservice</param>
        /// <example>InteractionClient.TVSI_Service_Ref.CCWS tvsiWS = (InteractionClient.TVSI_Service_Ref.CCWS)Utilities.GetService(typeof(InteractionClient.TVSI_Service_Ref.CCWS));</example>
        /// <returns></returns>
        public static SoapHttpClientProtocol GetWebService(string serviceName,
          string wsAbsolutePath, Type type, string className)
        {
            string web_domain = "";
            if (HttpContext.Current.Request.ServerVariables["SERVER_NAME"].ToLower() == "localhost")
                web_domain = ConfigurationSettings.AppSettings["WEB.SERVICE." + serviceName + "_LOCAL"];
            else
                web_domain = ConfigurationSettings.AppSettings["WEB.SERVICE." + serviceName];

            string encode = ConfigurationSettings.AppSettings["WEB.SERVICE.ENCODE"];
            string timeOut = ConfigurationSettings.AppSettings["WEB.SERVICE.TIMEOUT"];
            string url = web_domain + wsAbsolutePath;
            return GetWebService(url, encode, timeOut, type, className);
        }

    }
}
