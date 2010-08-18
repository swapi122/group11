
/*
'===============================================================================
'  LinqHelper.DAO.LqToChuc
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
	public class LqToChuc : LqToChucBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqToChuc()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqToChuc
		/// </summary>
		/// <returns>An instant of LqToChuc class</returns>
		public static LqToChuc CreateInstant()
		{
			return new LqToChuc();
		}
	}
}
