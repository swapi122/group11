

/*
'===============================================================================
'  LinqHelper.BUS.LqHoKhau
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
	public class LqHoKhauBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHoKhauBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqHoKhauBus
		/// </summary>
		/// <returns>An instant of LqHoKhau class</returns>
		public static LqHoKhauBus CreateInstant()
		{
			return new LqHoKhauBus();
		}
	}
}
