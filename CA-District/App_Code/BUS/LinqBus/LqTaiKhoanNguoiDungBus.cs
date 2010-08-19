

/*
'===============================================================================
'  LinqHelper.BUS.LqTaiKhoanNguoiDung
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.BUS
{
	public class LqTaiKhoanNguoiDungBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTaiKhoanNguoiDungBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTaiKhoanNguoiDungBus
		/// </summary>
		/// <returns>An instant of LqTaiKhoanNguoiDung class</returns>
		public static LqTaiKhoanNguoiDungBus CreateInstant()
		{
			return new LqTaiKhoanNguoiDungBus();
		}
	}
}
