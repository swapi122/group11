

/*
'===============================================================================
'  LinqHelper.BUS.LqXuLyDoiTuong
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
	public class LqXuLyDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqXuLyDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqXuLyDoiTuongBus
		/// </summary>
		/// <returns>An instant of LqXuLyDoiTuong class</returns>
		public static LqXuLyDoiTuongBus CreateInstant()
		{
			return new LqXuLyDoiTuongBus();
		}
	}
}
