

/*
'===============================================================================
'  LayerHelper.CAQ.BL.VanDeKhacManager
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
	public class VanDeKhacBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VanDeKhacBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VanDeKhacBus
		/// </summary>
		/// <returns>An instant of VanDeKhacBus class</returns>
		public static VanDeKhacBus CreateInstant()
		{
			return new VanDeKhacBus();
		}
	}
}
