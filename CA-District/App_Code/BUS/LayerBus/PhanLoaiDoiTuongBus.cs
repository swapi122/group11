

/*
'===============================================================================
'  LayerHelper.CAQ.BL.PhanLoaiDoiTuongManager
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
	public class PhanLoaiDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhanLoaiDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PhanLoaiDoiTuongBus
		/// </summary>
		/// <returns>An instant of PhanLoaiDoiTuongBus class</returns>
		public static PhanLoaiDoiTuongBus CreateInstant()
		{
			return new PhanLoaiDoiTuongBus();
		}
	}
}
