
/*
'===============================================================================
'  LinqHelper.DAO.LqPhuongThucThuDoan
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
	public class LqPhuongThucThuDoan : LqPhuongThucThuDoanBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhuongThucThuDoan()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqPhuongThucThuDoan
		/// </summary>
		/// <returns>An instant of LqPhuongThucThuDoan class</returns>
		public static LqPhuongThucThuDoan CreateInstant()
		{
			return new LqPhuongThucThuDoan();
		}
	}
}
