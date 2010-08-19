

/*
'===============================================================================
'  LayerHelper.CAQ.BL.OkhuVucManager
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
	public class OkhuVucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OkhuVucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of OkhuVucBus
		/// </summary>
		/// <returns>An instant of OkhuVucBus class</returns>
		public static OkhuVucBus CreateInstant()
		{
			return new OkhuVucBus();
		}
	}
}
