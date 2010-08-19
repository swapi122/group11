

/*
'===============================================================================
'  LinqHelper.BUS.LqPhuongTienGayAn
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
	public class LqPhuongTienGayAnBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhuongTienGayAnBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqPhuongTienGayAnBus
		/// </summary>
		/// <returns>An instant of LqPhuongTienGayAn class</returns>
		public static LqPhuongTienGayAnBus CreateInstant()
		{
			return new LqPhuongTienGayAnBus();
		}
	}
}
