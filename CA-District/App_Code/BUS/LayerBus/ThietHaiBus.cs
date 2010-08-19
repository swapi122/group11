

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

namespace LayerHelper.CAQ.BUS
{
	public class ThietHaiBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThietHaiBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ThietHaiBus
		/// </summary>
		/// <returns>An instant of ThietHaiBus class</returns>
		public static ThietHaiBus CreateInstant()
		{
			return new ThietHaiBus();
		}
	}
}
