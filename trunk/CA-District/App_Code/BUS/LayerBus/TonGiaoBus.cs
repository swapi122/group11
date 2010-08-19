

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

namespace LayerHelper.CAQ.BUS
{
	public class TonGiaoBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TonGiaoBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TonGiaoBus
		/// </summary>
		/// <returns>An instant of TonGiaoBus class</returns>
		public static TonGiaoBus CreateInstant()
		{
			return new TonGiaoBus();
		}
	}
}
