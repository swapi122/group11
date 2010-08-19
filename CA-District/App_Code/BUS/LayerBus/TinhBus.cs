

/*
'===============================================================================
'  LayerHelper.CAQ.BL.TinhManager
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
	public class TinhBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TinhBus
		/// </summary>
		/// <returns>An instant of TinhBus class</returns>
		public static TinhBus CreateInstant()
		{
			return new TinhBus();
		}
	}
}
