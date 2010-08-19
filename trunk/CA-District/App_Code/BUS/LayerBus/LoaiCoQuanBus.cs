

/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiCoQuanManager
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
	public class LoaiCoQuanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiCoQuanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LoaiCoQuanBus
		/// </summary>
		/// <returns>An instant of LoaiCoQuanBus class</returns>
		public static LoaiCoQuanBus CreateInstant()
		{
			return new LoaiCoQuanBus();
		}
	}
}
