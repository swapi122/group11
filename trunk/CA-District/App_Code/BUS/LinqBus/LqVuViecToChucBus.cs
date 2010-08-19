

/*
'===============================================================================
'  LinqHelper.BUS.LqVuViecToChuc
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
	public class LqVuViecToChucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecToChucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVuViecToChucBus
		/// </summary>
		/// <returns>An instant of LqVuViecToChuc class</returns>
		public static LqVuViecToChucBus CreateInstant()
		{
			return new LqVuViecToChucBus();
		}
	}
}
