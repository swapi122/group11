
/*
'===============================================================================
'  LayerHelper.CAQ.BL.DanhGiaTinManager
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
	public class DanhGiaTinManager : DanhGiaTinManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DanhGiaTinManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DanhGiaTinManager
		/// </summary>
		/// <returns>An instant of DanhGiaTinManager class</returns>
		public static DanhGiaTinManager CreateInstant()
		{
			return new DanhGiaTinManager();
		}
	}
}
