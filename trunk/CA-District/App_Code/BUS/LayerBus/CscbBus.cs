

/*
'===============================================================================
'  LayerHelper.CAQ.BL.CscbManager
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
	public class CscbBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CscbBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of CscbBus
		/// </summary>
		/// <returns>An instant of CscbBus class</returns>
		public static CscbBus CreateInstant()
		{
			return new CscbBus();
		}
	}
}
