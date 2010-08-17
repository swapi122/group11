
/*
'===============================================================================
'  LayerHelper.CAQ.BL.OkhuVucManager
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

namespace LayerHelper.CAQ.BLL
{
	public class OkhuVucManager : OkhuVucManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OkhuVucManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of OkhuVucManager
		/// </summary>
		/// <returns>An instant of OkhuVucManager class</returns>
		public static OkhuVucManager CreateInstant()
		{
			return new OkhuVucManager();
		}
	}
}
