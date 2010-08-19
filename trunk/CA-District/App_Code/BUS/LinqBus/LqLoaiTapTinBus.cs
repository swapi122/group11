

/*
'===============================================================================
'  LinqHelper.BUS.LqLoaiTapTin
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
	public class LqLoaiTapTinBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiTapTinBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiTapTinBus
		/// </summary>
		/// <returns>An instant of LqLoaiTapTin class</returns>
		public static LqLoaiTapTinBus CreateInstant()
		{
			return new LqLoaiTapTinBus();
		}
	}
}
