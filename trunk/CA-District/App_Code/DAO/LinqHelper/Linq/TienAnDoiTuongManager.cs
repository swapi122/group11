
/*
'===============================================================================
'  LinqHelper.DAO.LqTienAnDoiTuong
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
	public class LqTienAnDoiTuong : LqTienAnDoiTuongBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTienAnDoiTuong()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTienAnDoiTuong
		/// </summary>
		/// <returns>An instant of LqTienAnDoiTuong class</returns>
		public static LqTienAnDoiTuong CreateInstant()
		{
			return new LqTienAnDoiTuong();
		}
	}
}
