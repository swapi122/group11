

/*
'===============================================================================
'  LayerHelper.CAQ.BL.CoToChucManager
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
	public class CoToChucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CoToChucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of CoToChucBus
		/// </summary>
		/// <returns>An instant of CoToChucBus class</returns>
		public static CoToChucBus CreateInstant()
		{
			return new CoToChucBus();
		}
	}
}
