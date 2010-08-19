

/*
'===============================================================================
'  LinqHelper.BUS.LqTinhTrangTheTrang
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
	public class LqTinhTrangTheTrangBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhTrangTheTrangBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTinhTrangTheTrangBus
		/// </summary>
		/// <returns>An instant of LqTinhTrangTheTrang class</returns>
		public static LqTinhTrangTheTrangBus CreateInstant()
		{
			return new LqTinhTrangTheTrangBus();
		}
	}
}
