
/*
'===============================================================================
'  LinqHelper.DAO.LqSoDoToChuc
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
	public class LqSoDoToChuc : LqSoDoToChucBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqSoDoToChuc()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqSoDoToChuc
		/// </summary>
		/// <returns>An instant of LqSoDoToChuc class</returns>
		public static LqSoDoToChuc CreateInstant()
		{
			return new LqSoDoToChuc();
		}
	}
}
