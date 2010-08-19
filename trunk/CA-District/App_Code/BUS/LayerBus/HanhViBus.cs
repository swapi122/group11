

/*
'===============================================================================
'  LayerHelper.CAQ.BL.HanhViManager
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
	public class HanhViBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HanhViBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of HanhViBus
		/// </summary>
		/// <returns>An instant of HanhViBus class</returns>
		public static HanhViBus CreateInstant()
		{
			return new HanhViBus();
		}
	}
}
