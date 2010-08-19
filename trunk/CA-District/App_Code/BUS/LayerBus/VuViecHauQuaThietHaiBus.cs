

/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecHauQuaThietHaiManager
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
	public class VuViecHauQuaThietHaiBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecHauQuaThietHaiBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VuViecHauQuaThietHaiBus
		/// </summary>
		/// <returns>An instant of VuViecHauQuaThietHaiBus class</returns>
		public static VuViecHauQuaThietHaiBus CreateInstant()
		{
			return new VuViecHauQuaThietHaiBus();
		}
	}
}
