

/*
'===============================================================================
'  LayerHelper.CAQ.BL.NanNhanManager
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
	public class NanNhanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NanNhanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NanNhanBus
		/// </summary>
		/// <returns>An instant of NanNhanBus class</returns>
		public static NanNhanBus CreateInstant()
		{
			return new NanNhanBus();
		}
	}
}
