
/*
'===============================================================================
'  LayerHelper.CAQ.BL.TonGiaoManager
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
	public class TonGiaoManager : TonGiaoManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TonGiaoManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TonGiaoManager
		/// </summary>
		/// <returns>An instant of TonGiaoManager class</returns>
		public static TonGiaoManager CreateInstant()
		{
			return new TonGiaoManager();
		}
	}
}
