
/*
'===============================================================================
'  LinqHelper.DAO.LqVuViec
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
	public class LqVuViec : LqVuViecBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViec()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVuViec
		/// </summary>
		/// <returns>An instant of LqVuViec class</returns>
		public static LqVuViec CreateInstant()
		{
			return new LqVuViec();
		}
	}
}
