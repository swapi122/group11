
/*
'===============================================================================
'  LinqHelper.DAO.LqCoToChuc
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
	public class LqCoToChuc : LqCoToChucBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqCoToChuc()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqCoToChuc
		/// </summary>
		/// <returns>An instant of LqCoToChuc class</returns>
		public static LqCoToChuc CreateInstant()
		{
			return new LqCoToChuc();
		}
	}
}
