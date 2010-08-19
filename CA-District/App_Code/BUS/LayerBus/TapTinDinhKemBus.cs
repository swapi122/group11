

/*
'===============================================================================
'  LayerHelper.CAQ.BL.TapTinDinhKemManager
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
	public class TapTinDinhKemBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TapTinDinhKemBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TapTinDinhKemBus
		/// </summary>
		/// <returns>An instant of TapTinDinhKemBus class</returns>
		public static TapTinDinhKemBus CreateInstant()
		{
			return new TapTinDinhKemBus();
		}
	}
}
