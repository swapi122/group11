
/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecDoiTuongManager
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
	public class VuViecDoiTuongManager : VuViecDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecDoiTuongManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VuViecDoiTuongManager
		/// </summary>
		/// <returns>An instant of VuViecDoiTuongManager class</returns>
		public static VuViecDoiTuongManager CreateInstant()
		{
			return new VuViecDoiTuongManager();
		}
	}
}
