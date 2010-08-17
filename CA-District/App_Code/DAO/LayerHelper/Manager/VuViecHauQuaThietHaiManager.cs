
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

namespace LayerHelper.CAQ.BLL
{
	public class VuViecHauQuaThietHaiManager : VuViecHauQuaThietHaiManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecHauQuaThietHaiManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VuViecHauQuaThietHaiManager
		/// </summary>
		/// <returns>An instant of VuViecHauQuaThietHaiManager class</returns>
		public static VuViecHauQuaThietHaiManager CreateInstant()
		{
			return new VuViecHauQuaThietHaiManager();
		}
	}
}
