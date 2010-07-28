using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Globalization;
using System.Collections;
using System.Threading;

/// <summary>
/// Summary description for FDateTime
/// </summary>
namespace WB.Library
{
    public class FDateTime
    {

        public static DateTime FirstDateOfWeek(DateTime date)
        {
            CultureInfo info = Thread.CurrentThread.CurrentCulture;
            DayOfWeek dOfWeek = info.Calendar.GetDayOfWeek(date);
            Hashtable h = new Hashtable();
            h["Sunday"] = 6;
            h["Monday"] = 0;
            h["Tuesday"] = 1;
            h["Wednesday"] = 2;
            h["Thursday"] = 3;
            h["Friday"] = 4;
            h["Saturday"] = 5;
            double indexOfday = double.Parse(h[dOfWeek.ToString()].ToString());
            return date.AddDays(-indexOfday);
        }

        public static DateTime LastDateOfWeek(DateTime date)
        {
            CultureInfo info = Thread.CurrentThread.CurrentCulture;
            DayOfWeek dOfWeek = info.Calendar.GetDayOfWeek(date);
            Hashtable h = new Hashtable();
            h["Sunday"] = 6;
            h["Monday"] = 0;
            h["Tuesday"] = 1;
            h["Wednesday"] = 2;
            h["Thursday"] = 3;
            h["Friday"] = 4;
            h["Saturday"] = 5;
            double indexOfday = double.Parse(h[dOfWeek.ToString()].ToString());
            return date.AddDays(6 - indexOfday);
        }


        public static DateTime ResetTime(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
        }

        public static int CompareDate(DateTime dt1, DateTime dt2)
        {
            dt1 = ResetTime(dt1);
            dt2 = ResetTime(dt2);
            return dt1.CompareTo(dt2);
        }

        public static int Days(DateTime dt1, DateTime dt2)
        {
            dt1 = ResetTime(dt1);
            dt2 = ResetTime(dt2);

            return dt2.Subtract(dt1).Days + 1;
        }

        public static string FormatDateTime(DateTime dt, string Lang)
        {
            if (Lang == "vi-VN")
            {
                return GetDayName(dt.DayOfWeek) + dt.ToString("dd/MM/yyyy - H:mm");
            }
            return dt.ToString("dddd, MMMM dd, yyyy - H:mm");
        }

        public static string FormatDate(DateTime dt, string Lang)
        {
            if (Lang == "vi-VN")
            {
                return dt.ToString("dd/MM/yyyy");
            }
            return dt.ToString("dddd, MMMM dd, yyyy");
        }

        public static string FormatDateFull(DateTime dt, string Lang)
        {
            if (Lang == "vi-VN")
            {
                return GetDayName(dt.DayOfWeek) + dt.ToString("dd/MM/yyyy");
            }
            return dt.ToString("dddd, MMMM dd, yyyy");
        }

        public static string GetDayName(DayOfWeek dayofweek)
        {
            string st = "";
            switch (dayofweek)
            {
                case DayOfWeek.Monday:
                    st = "Thứ Hai ";
                    break;
                case DayOfWeek.Tuesday:
                    st = "Thứ Ba ";
                    break;
                case DayOfWeek.Wednesday:
                    st = "Thứ Tư ";
                    break;
                case DayOfWeek.Thursday:
                    st = "Thứ Năm ";
                    break;
                case DayOfWeek.Friday:
                    st = "Thứ Sáu ";
                    break;
                case DayOfWeek.Saturday:
                    st = "Thứ Bảy ";
                    break;
                case DayOfWeek.Sunday:
                    st = "Chủ Nhật ";
                    break;
            }
            return st;
        }
       
        public static string FormatDate(DateTime dt)
        {
            return FormatDate(dt, CultureInfo.CurrentCulture.Name);
        }

        public static string FormatDateTime(DateTime dt)
        {
            return FormatDateTime(dt, CultureInfo.CurrentCulture.Name);
        }
        /// <summary>
        /// Tra ve chuoi dinh dang theo format co dinh
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DefaultFormatDate(DateTime dt)
        {
            return dt.ToString("dd/MM/yyyy");
        }
        /// <summary>
        /// Tra ve chuoi dinh dang theo format co dinh
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DefaultFormatDate(string dt)
        {
            return DateTime.Parse(dt).ToString("dd/MM/yyyy");
        }
       
        /// <summary>
        /// Lay du lieu kieu ngay thang luu xuong DB
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DatabaseFormatDate(DateTime dt)
        {
            return dt.ToString("yyyy/MM/dd");
        }
        public static string FormatTime(int Minutes, string Lang)
        {
            int m = Minutes % 60;
            int h = Minutes - m;
            string strM = "minutes";
            string strH = "hours";
            if (Lang == "vi-VN")
            {
                strM = "phút";
                strH = "giờ";
            }
            string time = "";

            if (h > 0)
            {
                time += (h / 60).ToString() + " " + strH + " ";
            }

            if (m > 0)
            {
                time += m.ToString() + " " + strM + " ";
            }

            return time;
        }

        public static string FormatTime(int Minutes)
        {
            return FormatTime(Minutes, CultureInfo.CurrentCulture.Name);
        }

        public static DateTime ConverDateFromString(string date)
        {
            string year = date.Substring(0, 4);
            string month = date.Substring(4, 2);
            string day = date.Substring(6, 2);
            string Date = "";
            Date += day + "/" + month + "/" + year;
            return ConvertDate(Date);
        }
        
        public static DateTime ConvertDate(string value)
        {
            try
            {
                return DateTime.Parse(value, new CultureInfo("vi-VN"), DateTimeStyles.NoCurrentDateDefault);
            }
            catch
            {
                return DateTime.Now;
            }
        }

        public static DateTime ConvertTime(string value)
        {
            try
            {
                string[] st = value.Trim().Split(':');
                int[] time = { int.Parse(st[0]), int.Parse(st[1]) };
                return new DateTime(1900, 1, 1, time[0], time[1], 0);
            }
            catch
            {
            }
            return DateTime.Now;
        }

        public static bool IsDate(string date)
        {
            try
            {
                DateTime.Parse(date, new CultureInfo("vi-VN"), DateTimeStyles.NoCurrentDateDefault);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string ConvertInt2Time(int seconds)
        {
            return (seconds / 3600).ToString().PadLeft(2,'0') + ":" +
                ((seconds % 3600) / 60).ToString().PadLeft(2, '0') + ":" +
                ((seconds % 3600) % 60).ToString().PadLeft(2, '0');
        }

        public static int StringToTime(string st)
        {
            string[] s = st.Split(':');
            TimeSpan ts = new TimeSpan(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]));
            return ts.Hours * 3600 + ts.Minutes * 60 + ts.Seconds;
        }

    }
}