
/*
'===============================================================================
'  LayerHelper.CAQ.BL.ChucNangManager
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using WB.Library;
namespace LayerHelper.CAQ.BLL
{
	public class ChucNangManager : ChucNangManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ChucNangManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ChucNangManager
		/// </summary>
		/// <returns>An instant of ChucNangManager class</returns>
		public static ChucNangManager CreateInstant()
		{
			return new ChucNangManager();
		}
        public DataTable Get()
        {
            string strSQL = "";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionString, CommandType.StoredProcedure, strSQL);
        }
	}
}
