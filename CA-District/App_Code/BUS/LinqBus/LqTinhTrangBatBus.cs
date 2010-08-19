

/*
'===============================================================================
'  LinqHelper.BUS.LqTinhTrangBat
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
	public class LqTinhTrangBatBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhTrangBatBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTinhTrangBatBus
		/// </summary>
		/// <returns>An instant of LqTinhTrangBat class</returns>
		public static LqTinhTrangBatBus CreateInstant()
		{
			return new LqTinhTrangBatBus();
		}
	}
}
