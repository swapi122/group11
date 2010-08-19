
/*
'===============================================================================
'  LinqHelper.DAO.LqTrinhDoHocVan
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
	public class LqTrinhDoHocVan : LqTrinhDoHocVanBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTrinhDoHocVan()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTrinhDoHocVan
		/// </summary>
		/// <returns>An instant of LqTrinhDoHocVan class</returns>
		public static LqTrinhDoHocVan CreateInstant()
		{
			return new LqTrinhDoHocVan();
		}
	}
}
