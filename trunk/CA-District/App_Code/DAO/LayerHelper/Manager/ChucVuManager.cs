
/*
'===============================================================================
'  LayerHelper.CAQ.BL.ChucVuManager
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
	public class ChucVuManager : ChucVuManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ChucVuManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ChucVuManager
		/// </summary>
		/// <returns>An instant of ChucVuManager class</returns>
		public static ChucVuManager CreateInstant()
		{
			return new ChucVuManager();
		}
	}
}
