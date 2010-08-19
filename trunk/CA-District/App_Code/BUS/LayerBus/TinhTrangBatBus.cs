

/*
'===============================================================================
'  LayerHelper.CAQ.BL.TinhTrangBatManager
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
	public class TinhTrangBatBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhTrangBatBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TinhTrangBatBus
		/// </summary>
		/// <returns>An instant of TinhTrangBatBus class</returns>
		public static TinhTrangBatBus CreateInstant()
		{
			return new TinhTrangBatBus();
		}
	}
}
