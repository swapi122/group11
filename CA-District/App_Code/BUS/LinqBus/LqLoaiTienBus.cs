

/*
'===============================================================================
'  LinqHelper.BUS.LqLoaiTien
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
	public class LqLoaiTienBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiTienBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiTienBus
		/// </summary>
		/// <returns>An instant of LqLoaiTien class</returns>
		public static LqLoaiTienBus CreateInstant()
		{
			return new LqLoaiTienBus();
		}
	}
}
