

/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecToChucManager
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
	public class VuViecToChucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecToChucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VuViecToChucBus
		/// </summary>
		/// <returns>An instant of VuViecToChucBus class</returns>
		public static VuViecToChucBus CreateInstant()
		{
			return new VuViecToChucBus();
		}
	}
}
