

/*
'===============================================================================
'  LinqHelper.BUS.LqNanNhanVuViec
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
	public class LqNanNhanVuViecBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNanNhanVuViecBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNanNhanVuViecBus
		/// </summary>
		/// <returns>An instant of LqNanNhanVuViec class</returns>
		public static LqNanNhanVuViecBus CreateInstant()
		{
			return new LqNanNhanVuViecBus();
		}
	}
}
