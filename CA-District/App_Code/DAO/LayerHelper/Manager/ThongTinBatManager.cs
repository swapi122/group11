
/*
'===============================================================================
'  LayerHelper.CAQ.BL.ThongTinBatManager
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
	public class ThongTinBatManager : ThongTinBatManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThongTinBatManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ThongTinBatManager
		/// </summary>
		/// <returns>An instant of ThongTinBatManager class</returns>
		public static ThongTinBatManager CreateInstant()
		{
			return new ThongTinBatManager();
		}
	}
}
