

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

namespace LayerHelper.CAQ.BUS
{
	public class ThonBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThonBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ThonBus
		/// </summary>
		/// <returns>An instant of ThonBus class</returns>
		public static ThonBus CreateInstant()
		{
			return new ThonBus();
		}
	}
}
