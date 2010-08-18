using System;
using System.Configuration;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace LinqHelper
{
    public class LqProvider : DataContext
    {
        static string _connection = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;
        static System.Data.Linq.Mapping.MappingSource mappingSources = new AttributeMappingSource();

        public LqProvider()
            : base(_connection, mappingSources)
		{
		}
    }
}
