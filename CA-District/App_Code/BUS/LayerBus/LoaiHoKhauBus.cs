

/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiHoKhauManager
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
	public class LoaiHoKhauBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiHoKhauBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LoaiHoKhauBus
		/// </summary>
		/// <returns>An instant of LoaiHoKhauBus class</returns>
		public static LoaiHoKhauBus CreateInstant()
		{
			return new LoaiHoKhauBus();
		}
	}
}
