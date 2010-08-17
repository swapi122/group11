
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

namespace LayerHelper.CAQ.BLL
{
	public class ColumnsCollectionManager : ColumnsCollectionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ColumnsCollectionManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ColumnsCollectionManager
		/// </summary>
		/// <returns>An instant of ColumnsCollectionManager class</returns>
		public static ColumnsCollectionManager CreateInstant()
		{
			return new ColumnsCollectionManager();
		}
	}
}
