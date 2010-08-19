

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

namespace LayerHelper.CAQ.BUS
{
	public class NanNhanVuViecBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NanNhanVuViecBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NanNhanVuViecBus
		/// </summary>
		/// <returns>An instant of NanNhanVuViecBus class</returns>
		public static NanNhanVuViecBus CreateInstant()
		{
			return new NanNhanVuViecBus();
		}
	}
}
