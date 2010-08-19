

/*
'===============================================================================
'  LinqHelper.BUS.LqVuViecDoiTuong
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
	public class LqVuViecDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVuViecDoiTuongBus
		/// </summary>
		/// <returns>An instant of LqVuViecDoiTuong class</returns>
		public static LqVuViecDoiTuongBus CreateInstant()
		{
			return new LqVuViecDoiTuongBus();
		}
	}
}
