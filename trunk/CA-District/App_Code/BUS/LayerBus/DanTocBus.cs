

/*
'===============================================================================
'  LayerHelper.CAQ.BL.DanTocManager
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
	public class DanTocBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DanTocBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DanTocBus
		/// </summary>
		/// <returns>An instant of DanTocBus class</returns>
		public static DanTocBus CreateInstant()
		{
			return new DanTocBus();
		}
	}
}
