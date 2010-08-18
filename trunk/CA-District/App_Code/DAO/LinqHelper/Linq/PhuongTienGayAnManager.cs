
/*
'===============================================================================
'  LinqHelper.DAO.LqPhuongTienGayAn
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
	public class LqPhuongTienGayAn : LqPhuongTienGayAnBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhuongTienGayAn()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqPhuongTienGayAn
		/// </summary>
		/// <returns>An instant of LqPhuongTienGayAn class</returns>
		public static LqPhuongTienGayAn CreateInstant()
		{
			return new LqPhuongTienGayAn();
		}
	}
}
