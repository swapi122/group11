

/*
'===============================================================================
'  LayerHelper.CAQ.BL.ColumnsCollectionManager
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
	public class ColumnsCollectionBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ColumnsCollectionBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ColumnsCollectionBus
		/// </summary>
		/// <returns>An instant of ColumnsCollectionBus class</returns>
		public static ColumnsCollectionBus CreateInstant()
		{
			return new ColumnsCollectionBus();
		}
	}
}
