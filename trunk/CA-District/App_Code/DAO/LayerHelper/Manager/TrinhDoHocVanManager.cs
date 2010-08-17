
/*
'===============================================================================
'  LayerHelper.CAQ.BL.TrinhDoHocVanManager
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
	public class TrinhDoHocVanManager : TrinhDoHocVanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TrinhDoHocVanManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TrinhDoHocVanManager
		/// </summary>
		/// <returns>An instant of TrinhDoHocVanManager class</returns>
		public static TrinhDoHocVanManager CreateInstant()
		{
			return new TrinhDoHocVanManager();
		}
	}
}
