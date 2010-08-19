

/*
'===============================================================================
'  LinqHelper.BUS.LqDoiTuong
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
	public class LqDoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDoiTuongBus
		/// </summary>
		/// <returns>An instant of LqDoiTuong class</returns>
		public static LqDoiTuongBus CreateInstant()
		{
			return new LqDoiTuongBus();
		}
	}
}
