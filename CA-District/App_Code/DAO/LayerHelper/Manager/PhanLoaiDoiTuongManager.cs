
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

namespace LayerHelper.CAQ.BLL
{
	public class PhanLoaiDoiTuongManager : PhanLoaiDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhanLoaiDoiTuongManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PhanLoaiDoiTuongManager
		/// </summary>
		/// <returns>An instant of PhanLoaiDoiTuongManager class</returns>
		public static PhanLoaiDoiTuongManager CreateInstant()
		{
			return new PhanLoaiDoiTuongManager();
		}
	}
}
