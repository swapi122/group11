
/*
'===============================================================================
'  LayerHelper.CAQ.BL.PhuongTienGayAnManager
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
	public class PhuongTienGayAnManager : PhuongTienGayAnManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhuongTienGayAnManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PhuongTienGayAnManager
		/// </summary>
		/// <returns>An instant of PhuongTienGayAnManager class</returns>
		public static PhuongTienGayAnManager CreateInstant()
		{
			return new PhuongTienGayAnManager();
		}
	}
}
