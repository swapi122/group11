

/*
'===============================================================================
'  LayerHelper.CAQ.BL.TienSuDoiTuongManager
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
	public class TienSuDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TienSuDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TienSuDoiTuongBus
		/// </summary>
		/// <returns>An instant of TienSuDoiTuongBus class</returns>
		public static TienSuDoiTuongBus CreateInstant()
		{
			return new TienSuDoiTuongBus();
		}
	}
}
