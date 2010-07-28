using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WB.Library
{
    public class FGuid
    {
        public static bool IsGuid(string GuidId)
        {
            if (string.IsNullOrEmpty(GuidId))
                return false;
            string parttern = "########-####-####-####-############";
            string guid = GuidId.ToLower();

            Regex reg = new Regex(parttern.Replace("#", "[a-z0-9]"));
            if (reg.IsMatch(guid) && guid.Length == parttern.Length)
                return true;
            return false;
        }

        public static Guid ToGuid(string value)
        {
            if (!string.IsNullOrEmpty(value) && IsGuid(value))
                return new Guid(value);
            return Guid.Empty;
        }

        public static Guid ToGuid(object value)
        {
            if (!Convert.IsDBNull(value))
                return ToGuid(value.ToString());
            return Guid.Empty;
        }
    }
}
