

/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiTapTinManager
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
	public class LoaiTapTinBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiTapTinBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LoaiTapTinBus
		/// </summary>
		/// <returns>An instant of LoaiTapTinBus class</returns>
		public static LoaiTapTinBus CreateInstant()
		{
			return new LoaiTapTinBus();
		}
	}
}
