
/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiDoiTuongManager
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
	public class LoaiDoiTuongManager : LoaiDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiDoiTuongManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LoaiDoiTuongManager
		/// </summary>
		/// <returns>An instant of LoaiDoiTuongManager class</returns>
		public static LoaiDoiTuongManager CreateInstant()
		{
			return new LoaiDoiTuongManager();
		}
	}
}
