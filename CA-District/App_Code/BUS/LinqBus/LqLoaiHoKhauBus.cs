

/*
'===============================================================================
'  LinqHelper.BUS.LqLoaiHoKhau
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
	public class LqLoaiHoKhauBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiHoKhauBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiHoKhauBus
		/// </summary>
		/// <returns>An instant of LqLoaiHoKhau class</returns>
		public static LqLoaiHoKhauBus CreateInstant()
		{
			return new LqLoaiHoKhauBus();
		}
	}
}
