

/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiTienManager
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
	public class LoaiTienBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiTienBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LoaiTienBus
		/// </summary>
		/// <returns>An instant of LoaiTienBus class</returns>
		public static LoaiTienBus CreateInstant()
		{
			return new LoaiTienBus();
		}
	}
}
