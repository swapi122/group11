
/*
'===============================================================================
'  LinqHelper.DAO.LqNanNhanVuViec
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
	public class LqNanNhanVuViec : LqNanNhanVuViecBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNanNhanVuViec()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNanNhanVuViec
		/// </summary>
		/// <returns>An instant of LqNanNhanVuViec class</returns>
		public static LqNanNhanVuViec CreateInstant()
		{
			return new LqNanNhanVuViec();
		}
	}
}
