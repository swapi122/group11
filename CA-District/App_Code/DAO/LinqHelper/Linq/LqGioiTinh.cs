
/*
'===============================================================================
'  LinqHelper.DAO.LqGioiTinh
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
	public class LqGioiTinh : LqGioiTinhBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqGioiTinh()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqGioiTinh
		/// </summary>
		/// <returns>An instant of LqGioiTinh class</returns>
		public static LqGioiTinh CreateInstant()
		{
			return new LqGioiTinh();
		}
	}
}
