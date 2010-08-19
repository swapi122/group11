

/*
'===============================================================================
'  LinqHelper.BUS.LqGioiTinh
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
	public class LqGioiTinhBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqGioiTinhBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqGioiTinhBus
		/// </summary>
		/// <returns>An instant of LqGioiTinh class</returns>
		public static LqGioiTinhBus CreateInstant()
		{
			return new LqGioiTinhBus();
		}
	}
}
