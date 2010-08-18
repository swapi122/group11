
/*
'===============================================================================
'  LinqHelper.DAO.LqTinhTrangBat
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
	public class LqTinhTrangBat : LqTinhTrangBatBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhTrangBat()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTinhTrangBat
		/// </summary>
		/// <returns>An instant of LqTinhTrangBat class</returns>
		public static LqTinhTrangBat CreateInstant()
		{
			return new LqTinhTrangBat();
		}
	}
}
