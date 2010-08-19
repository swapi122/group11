

/*
'===============================================================================
'  LinqHelper.BUS.LqTienSuDoiTuong
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
	public class LqTienSuDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTienSuDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTienSuDoiTuongBus
		/// </summary>
		/// <returns>An instant of LqTienSuDoiTuong class</returns>
		public static LqTienSuDoiTuongBus CreateInstant()
		{
			return new LqTienSuDoiTuongBus();
		}
	}
}
