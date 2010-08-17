
/*
'===============================================================================
'  LayerHelper.CAQ.BL.HoKhauDoiTuongManager
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
	public class HoKhauDoiTuongManager : HoKhauDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HoKhauDoiTuongManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of HoKhauDoiTuongManager
		/// </summary>
		/// <returns>An instant of HoKhauDoiTuongManager class</returns>
		public static HoKhauDoiTuongManager CreateInstant()
		{
			return new HoKhauDoiTuongManager();
		}
	}
}
