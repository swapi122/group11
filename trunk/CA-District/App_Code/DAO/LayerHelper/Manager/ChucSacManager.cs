
/*
'===============================================================================
'  LayerHelper.CAQ.BL.ChucSacManager
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
	public class ChucSacManager : ChucSacManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ChucSacManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ChucSacManager
		/// </summary>
		/// <returns>An instant of ChucSacManager class</returns>
		public static ChucSacManager CreateInstant()
		{
			return new ChucSacManager();
		}
	}
}
