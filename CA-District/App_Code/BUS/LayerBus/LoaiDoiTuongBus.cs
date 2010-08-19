

/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiDoiTuongManager
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
	public class LoaiDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LoaiDoiTuongBus
		/// </summary>
		/// <returns>An instant of LoaiDoiTuongBus class</returns>
		public static LoaiDoiTuongBus CreateInstant()
		{
			return new LoaiDoiTuongBus();
		}
	}
}
