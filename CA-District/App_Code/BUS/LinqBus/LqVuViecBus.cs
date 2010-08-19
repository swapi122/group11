

/*
'===============================================================================
'  LinqHelper.BUS.LqVuViec
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
	public class LqVuViecBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVuViecBus
		/// </summary>
		/// <returns>An instant of LqVuViec class</returns>
		public static LqVuViecBus CreateInstant()
		{
			return new LqVuViecBus();
		}
	}
}
