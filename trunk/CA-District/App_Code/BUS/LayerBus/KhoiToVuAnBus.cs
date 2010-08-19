

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

namespace LayerHelper.CAQ.BUS
{
	public class KhoiToVuAnBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KhoiToVuAnBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of KhoiToVuAnBus
		/// </summary>
		/// <returns>An instant of KhoiToVuAnBus class</returns>
		public static KhoiToVuAnBus CreateInstant()
		{
			return new KhoiToVuAnBus();
		}
	}
}
