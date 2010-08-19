

/*
'===============================================================================
'  LayerHelper.CAQ.BL.ChucNangNhomManager
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
	public class ChucNangNhomBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ChucNangNhomBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ChucNangNhomBus
		/// </summary>
		/// <returns>An instant of ChucNangNhomBus class</returns>
		public static ChucNangNhomBus CreateInstant()
		{
			return new ChucNangNhomBus();
		}
	}
}
