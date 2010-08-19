

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

namespace LayerHelper.CAQ.BUS
{
	public class TrinhDoHocVanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TrinhDoHocVanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TrinhDoHocVanBus
		/// </summary>
		/// <returns>An instant of TrinhDoHocVanBus class</returns>
		public static TrinhDoHocVanBus CreateInstant()
		{
			return new TrinhDoHocVanBus();
		}
	}
}
