
/*
'===============================================================================
'  LinqHelper.DAO.LqTaiKhoanNguoiDung
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
	public class LqTaiKhoanNguoiDung : LqTaiKhoanNguoiDungBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTaiKhoanNguoiDung()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTaiKhoanNguoiDung
		/// </summary>
		/// <returns>An instant of LqTaiKhoanNguoiDung class</returns>
		public static LqTaiKhoanNguoiDung CreateInstant()
		{
			return new LqTaiKhoanNguoiDung();
		}
	}
}
