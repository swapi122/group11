
/*
'===============================================================================
'  LinqHelper.DAO.LqVanDeKhac
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
	public class LqVanDeKhac : LqVanDeKhacBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVanDeKhac()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVanDeKhac
		/// </summary>
		/// <returns>An instant of LqVanDeKhac class</returns>
		public static LqVanDeKhac CreateInstant()
		{
			return new LqVanDeKhac();
		}
	}
}
