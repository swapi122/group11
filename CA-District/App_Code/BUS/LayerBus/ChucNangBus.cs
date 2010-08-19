

/*
'===============================================================================
'  LayerHelper.CAQ.BL.ChucNangManager
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
	public class ChucNangBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ChucNangBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ChucNangBus
		/// </summary>
		/// <returns>An instant of ChucNangBus class</returns>
		public static ChucNangBus CreateInstant()
		{
			return new ChucNangBus();
		}
	}
}
