using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{

    public class DataAccessAdapterFactory
    {
        public DataAccessAdapterBase CreateAdapter()
        {
            return (new LayerHelper.CAQ.DAL.DatabaseSpecific.DataAccessAdapter());
        }
    }

}

