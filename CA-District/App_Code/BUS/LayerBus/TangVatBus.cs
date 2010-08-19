

/*
'===============================================================================
'  LayerHelper.CAQ.BL.TangVatManager
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
	public class TangVatBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TangVatBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TangVatBus
		/// </summary>
		/// <returns>An instant of TangVatBus class</returns>
		public static TangVatBus CreateInstant()
		{
			return new TangVatBus();
		}
	}
}
