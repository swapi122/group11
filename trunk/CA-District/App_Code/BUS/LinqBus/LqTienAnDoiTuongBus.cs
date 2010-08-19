

/*
'===============================================================================
'  LinqHelper.BUS.LqTienAnDoiTuong
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
	public class LqTienAnDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTienAnDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTienAnDoiTuongBus
		/// </summary>
		/// <returns>An instant of LqTienAnDoiTuong class</returns>
		public static LqTienAnDoiTuongBus CreateInstant()
		{
			return new LqTienAnDoiTuongBus();
		}
	}
}
