
/*
'===============================================================================
'  LinqHelper.DAO.LqHoKhauDoiTuong
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
	public class LqHoKhauDoiTuong : LqHoKhauDoiTuongBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHoKhauDoiTuong()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqHoKhauDoiTuong
		/// </summary>
		/// <returns>An instant of LqHoKhauDoiTuong class</returns>
		public static LqHoKhauDoiTuong CreateInstant()
		{
			return new LqHoKhauDoiTuong();
		}
	}
}
