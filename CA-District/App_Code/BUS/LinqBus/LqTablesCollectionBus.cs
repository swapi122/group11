

/*
'===============================================================================
'  LinqHelper.BUS.LqTablesCollection
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.BUS
{
	public class LqTablesCollectionBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTablesCollectionBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTablesCollectionBus
		/// </summary>
		/// <returns>An instant of LqTablesCollection class</returns>
		public static LqTablesCollectionBus CreateInstant()
		{
			return new LqTablesCollectionBus();
		}
	}
}
