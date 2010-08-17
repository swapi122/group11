
/*
'===============================================================================
'  LayerHelper.CAQ.BL.DanhMucTinManager
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
	public class DanhMucTinManager : DanhMucTinManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DanhMucTinManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DanhMucTinManager
		/// </summary>
		/// <returns>An instant of DanhMucTinManager class</returns>
		public static DanhMucTinManager CreateInstant()
		{
			return new DanhMucTinManager();
		}
	}
}
