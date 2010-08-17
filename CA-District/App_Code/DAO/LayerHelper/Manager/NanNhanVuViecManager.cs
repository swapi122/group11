
/*
'===============================================================================
'  LayerHelper.CAQ.BL.NanNhanVuViecManager
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
	public class NanNhanVuViecManager : NanNhanVuViecManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NanNhanVuViecManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NanNhanVuViecManager
		/// </summary>
		/// <returns>An instant of NanNhanVuViecManager class</returns>
		public static NanNhanVuViecManager CreateInstant()
		{
			return new NanNhanVuViecManager();
		}
	}
}
