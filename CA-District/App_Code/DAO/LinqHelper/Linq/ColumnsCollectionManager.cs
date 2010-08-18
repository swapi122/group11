
/*
'===============================================================================
'  LinqHelper.DAO.LqColumnsCollection
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
	public class LqColumnsCollection : LqColumnsCollectionBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqColumnsCollection()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqColumnsCollection
		/// </summary>
		/// <returns>An instant of LqColumnsCollection class</returns>
		public static LqColumnsCollection CreateInstant()
		{
			return new LqColumnsCollection();
		}
	}
}
