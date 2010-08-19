

/*
'===============================================================================
'  LinqHelper.BUS.LqVanDeKhac
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
	public class LqVanDeKhacBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVanDeKhacBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVanDeKhacBus
		/// </summary>
		/// <returns>An instant of LqVanDeKhac class</returns>
		public static LqVanDeKhacBus CreateInstant()
		{
			return new LqVanDeKhacBus();
		}
	}
}
