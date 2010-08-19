

/*
'===============================================================================
'  LayerHelper.CAQ.BL.PhanLoaiDiaBanManager
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
	public class PhanLoaiDiaBanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhanLoaiDiaBanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PhanLoaiDiaBanBus
		/// </summary>
		/// <returns>An instant of PhanLoaiDiaBanBus class</returns>
		public static PhanLoaiDiaBanBus CreateInstant()
		{
			return new PhanLoaiDiaBanBus();
		}
	}
}
