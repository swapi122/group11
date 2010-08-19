

/*
'===============================================================================
'  LinqHelper.BUS.LqKhoiToVuAn
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
	public class LqKhoiToVuAnBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqKhoiToVuAnBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqKhoiToVuAnBus
		/// </summary>
		/// <returns>An instant of LqKhoiToVuAn class</returns>
		public static LqKhoiToVuAnBus CreateInstant()
		{
			return new LqKhoiToVuAnBus();
		}
	}
}
