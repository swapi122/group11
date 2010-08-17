
/*
'===============================================================================
'  LayerHelper.CAQ.BL.ThietHaiManager
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
	public class ThietHaiManager : ThietHaiManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThietHaiManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ThietHaiManager
		/// </summary>
		/// <returns>An instant of ThietHaiManager class</returns>
		public static ThietHaiManager CreateInstant()
		{
			return new ThietHaiManager();
		}
	}
}
