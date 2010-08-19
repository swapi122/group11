

/*
'===============================================================================
'  LayerHelper.CAQ.BL.GioiTinhManager
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
	public class GioiTinhBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public GioiTinhBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of GioiTinhBus
		/// </summary>
		/// <returns>An instant of GioiTinhBus class</returns>
		public static GioiTinhBus CreateInstant()
		{
			return new GioiTinhBus();
		}
	}
}
