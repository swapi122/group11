

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

namespace LayerHelper.CAQ.BUS
{
	public class ChucVuBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ChucVuBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ChucVuBus
		/// </summary>
		/// <returns>An instant of ChucVuBus class</returns>
		public static ChucVuBus CreateInstant()
		{
			return new ChucVuBus();
		}
	}
}
