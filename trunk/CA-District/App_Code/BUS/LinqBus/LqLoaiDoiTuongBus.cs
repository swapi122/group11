

/*
'===============================================================================
'  LinqHelper.BUS.LqLoaiDoiTuong
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
	public class LqLoaiDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiDoiTuongBus
		/// </summary>
		/// <returns>An instant of LqLoaiDoiTuong class</returns>
		public static LqLoaiDoiTuongBus CreateInstant()
		{
			return new LqLoaiDoiTuongBus();
		}
	}
}
