

/*
'===============================================================================
'  LinqHelper.BUS.LqHoKhauDoiTuong
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
	public class LqHoKhauDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHoKhauDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqHoKhauDoiTuongBus
		/// </summary>
		/// <returns>An instant of LqHoKhauDoiTuong class</returns>
		public static LqHoKhauDoiTuongBus CreateInstant()
		{
			return new LqHoKhauDoiTuongBus();
		}
	}
}
