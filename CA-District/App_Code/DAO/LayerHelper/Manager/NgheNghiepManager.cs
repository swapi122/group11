
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

namespace LayerHelper.CAQ.BLL
{
	public class NgheNghiepManager : NgheNghiepManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NgheNghiepManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NgheNghiepManager
		/// </summary>
		/// <returns>An instant of NgheNghiepManager class</returns>
		public static NgheNghiepManager CreateInstant()
		{
			return new NgheNghiepManager();
		}
	}
}
