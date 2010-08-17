
/*
'===============================================================================
'  LayerHelper.CAQ.BL.ThonManager
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
	public class ThonManager : ThonManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThonManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ThonManager
		/// </summary>
		/// <returns>An instant of ThonManager class</returns>
		public static ThonManager CreateInstant()
		{
			return new ThonManager();
		}
	}
}
