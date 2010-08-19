

/*
'===============================================================================
'  LayerHelper.CAQ.BL.TienAnDoiTuongManager
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
	public class TienAnDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TienAnDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TienAnDoiTuongBus
		/// </summary>
		/// <returns>An instant of TienAnDoiTuongBus class</returns>
		public static TienAnDoiTuongBus CreateInstant()
		{
			return new TienAnDoiTuongBus();
		}
	}
}
