

/*
'===============================================================================
'  LayerHelper.CAQ.BL.NgheNghiepDoiTuongManager
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
	public class NgheNghiepDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NgheNghiepDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NgheNghiepDoiTuongBus
		/// </summary>
		/// <returns>An instant of NgheNghiepDoiTuongBus class</returns>
		public static NgheNghiepDoiTuongBus CreateInstant()
		{
			return new NgheNghiepDoiTuongBus();
		}
	}
}
