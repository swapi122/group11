
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

namespace LayerHelper.CAQ.BLL
{
	public class PhanLoaiDiaBanManager : PhanLoaiDiaBanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhanLoaiDiaBanManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PhanLoaiDiaBanManager
		/// </summary>
		/// <returns>An instant of PhanLoaiDiaBanManager class</returns>
		public static PhanLoaiDiaBanManager CreateInstant()
		{
			return new PhanLoaiDiaBanManager();
		}
	}
}
