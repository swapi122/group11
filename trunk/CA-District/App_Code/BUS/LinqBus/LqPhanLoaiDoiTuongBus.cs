

/*
'===============================================================================
'  LinqHelper.BUS.LqPhanLoaiDoiTuong
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
	public class LqPhanLoaiDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhanLoaiDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqPhanLoaiDoiTuongBus
		/// </summary>
		/// <returns>An instant of LqPhanLoaiDoiTuong class</returns>
		public static LqPhanLoaiDoiTuongBus CreateInstant()
		{
			return new LqPhanLoaiDoiTuongBus();
		}
	}
}
