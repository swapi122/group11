
/*
'===============================================================================
'  LayerHelper.CAQ.BL.KhoiToVuAnManager
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
	public class KhoiToVuAnManager : KhoiToVuAnManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KhoiToVuAnManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of KhoiToVuAnManager
		/// </summary>
		/// <returns>An instant of KhoiToVuAnManager class</returns>
		public static KhoiToVuAnManager CreateInstant()
		{
			return new KhoiToVuAnManager();
		}
	}
}
