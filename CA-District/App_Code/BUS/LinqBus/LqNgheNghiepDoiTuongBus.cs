

/*
'===============================================================================
'  LinqHelper.BUS.LqNgheNghiepDoiTuong
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
	public class LqNgheNghiepDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNgheNghiepDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNgheNghiepDoiTuongBus
		/// </summary>
		/// <returns>An instant of LqNgheNghiepDoiTuong class</returns>
		public static LqNgheNghiepDoiTuongBus CreateInstant()
		{
			return new LqNgheNghiepDoiTuongBus();
		}
	}
}
