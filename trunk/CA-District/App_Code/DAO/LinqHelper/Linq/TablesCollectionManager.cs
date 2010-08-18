
/*
'===============================================================================
'  LinqHelper.DAO.LqTablesCollection
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqTablesCollection : LqTablesCollectionBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTablesCollection()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTablesCollection
		/// </summary>
		/// <returns>An instant of LqTablesCollection class</returns>
		public static LqTablesCollection CreateInstant()
		{
			return new LqTablesCollection();
		}
	}
}
