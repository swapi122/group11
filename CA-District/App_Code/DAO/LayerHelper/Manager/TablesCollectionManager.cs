
/*
'===============================================================================
'  LayerHelper.CAQ.BL.TablesCollectionManager
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
	public class TablesCollectionManager : TablesCollectionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TablesCollectionManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TablesCollectionManager
		/// </summary>
		/// <returns>An instant of TablesCollectionManager class</returns>
		public static TablesCollectionManager CreateInstant()
		{
			return new TablesCollectionManager();
		}
	}
}
