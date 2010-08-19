

/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecDoiTuongManager
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
	public class VuViecDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VuViecDoiTuongBus
		/// </summary>
		/// <returns>An instant of VuViecDoiTuongBus class</returns>
		public static VuViecDoiTuongBus CreateInstant()
		{
			return new VuViecDoiTuongBus();
		}
	}
}
