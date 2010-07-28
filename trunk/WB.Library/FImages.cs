using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Drawing;
using System.Web;
using System.Net;

namespace WB.Library
{
    public class FImages
    {
        public static Image GetFromUrl(string url)
        {
            WebClient myWebClient = new WebClient();
            //myWebClient.DownloadFile(
            if (File.Exists(url))
            {
                FileStream fs = new FileStream(url, FileMode.Open);
                if (fs != null)
                {
                    byte[] bimg = new byte[fs.Length];
                    MemoryStream ms = new MemoryStream(bimg);
                    return Image.FromStream(ms);
                }
                return null;
            }
            return null;
        }
    }
}
