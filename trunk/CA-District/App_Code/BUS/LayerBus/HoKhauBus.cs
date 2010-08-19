

/*
'===============================================================================
'  LayerHelper.CAQ.BL.HoKhauManager
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
	public class HoKhauBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HoKhauBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of HoKhauBus
		/// </summary>
		/// <returns>An instant of HoKhauBus class</returns>
		public static HoKhauBus CreateInstant()
		{
			return new HoKhauBus();
		}
	}
}
