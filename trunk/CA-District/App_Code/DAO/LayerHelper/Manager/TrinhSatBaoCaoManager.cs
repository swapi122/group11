
/*
'===============================================================================
'  LayerHelper.CAQ.BL.TrinhSatBaoCaoManager
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
	public class TrinhSatBaoCaoManager : TrinhSatBaoCaoManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TrinhSatBaoCaoManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TrinhSatBaoCaoManager
		/// </summary>
		/// <returns>An instant of TrinhSatBaoCaoManager class</returns>
		public static TrinhSatBaoCaoManager CreateInstant()
		{
			return new TrinhSatBaoCaoManager();
		}
	}
}
