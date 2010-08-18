
/*
'===============================================================================
'  LinqHelper.DAO.LqVuViecToChuc
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
	public class LqVuViecToChuc : LqVuViecToChucBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecToChuc()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVuViecToChuc
		/// </summary>
		/// <returns>An instant of LqVuViecToChuc class</returns>
		public static LqVuViecToChuc CreateInstant()
		{
			return new LqVuViecToChuc();
		}
	}
}
