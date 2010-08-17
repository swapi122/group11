
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

namespace LayerHelper.CAQ.BLL
{
	public class NgheNghiepDoiTuongManager : NgheNghiepDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NgheNghiepDoiTuongManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NgheNghiepDoiTuongManager
		/// </summary>
		/// <returns>An instant of NgheNghiepDoiTuongManager class</returns>
		public static NgheNghiepDoiTuongManager CreateInstant()
		{
			return new NgheNghiepDoiTuongManager();
		}
	}
}
