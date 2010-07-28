using System;
using System.Collections.Generic;
using System.Text;

namespace WB.Library
{
    public class UserID
    {
        public static string GetUserID(string name)
        {
            string strNotUnicode = FString.GetString(name);
            for(int i=0;i<strNotUnicode.Length-1;i++)
                if (strNotUnicode[i] == ' ')
                {
                    int count = 0;
                    for(int j=i+1;j<strNotUnicode.Length;j++)
                    {
                        if (strNotUnicode[j] == ' ')
                            count++;
                        else
                        {
                            strNotUnicode = strNotUnicode.Remove(i, count);
                            i = j;
                            break;
                        }
                    }
                }
            string[] HoTen=strNotUnicode.Split(' ');
            string Ten = HoTen[HoTen.Length - 1].Trim(); ;
            for (int i = 0; i < HoTen.Length - 1; i++)
            {
                HoTen[i] = HoTen[i].Trim();
                Ten += HoTen[i][0];
            }
            Ten = Ten.ToLower();
            return Ten;
        }
        public static string GetLastName(string fullName)
        {
            string[] HoTen = fullName.Split(' ');
            string Ten = HoTen[HoTen.Length - 1].Trim();
            return Ten;
        }
    }
}
