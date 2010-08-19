

/*
'===============================================================================
'  LayerHelper.CAQ.BL.NgheNghiepManager
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
	public class NgheNghiepBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NgheNghiepBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NgheNghiepBus
		/// </summary>
		/// <returns>An instant of NgheNghiepBus class</returns>
		public static NgheNghiepBus CreateInstant()
		{
			return new NgheNghiepBus();
		}
	}
}
