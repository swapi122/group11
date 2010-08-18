
/*
'===============================================================================
'  LinqHelper.DAO.LqNgheNghiep
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
	public class LqNgheNghiep : LqNgheNghiepBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNgheNghiep()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNgheNghiep
		/// </summary>
		/// <returns>An instant of LqNgheNghiep class</returns>
		public static LqNgheNghiep CreateInstant()
		{
			return new LqNgheNghiep();
		}
	}
}
