

/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecManager
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
	public class VuViecBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VuViecBus
		/// </summary>
		/// <returns>An instant of VuViecBus class</returns>
		public static VuViecBus CreateInstant()
		{
			return new VuViecBus();
		}
	}
}
