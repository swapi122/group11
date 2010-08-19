

/*
'===============================================================================
'  LayerHelper.CAQ.BL.ThongTinBatManager
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
	public class ThongTinBatBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThongTinBatBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ThongTinBatBus
		/// </summary>
		/// <returns>An instant of ThongTinBatBus class</returns>
		public static ThongTinBatBus CreateInstant()
		{
			return new ThongTinBatBus();
		}
	}
}
