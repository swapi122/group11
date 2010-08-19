

/*
'===============================================================================
'  LinqHelper.BUS.LqVuViecHauQuaThietHai
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
	public class LqVuViecHauQuaThietHaiBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecHauQuaThietHaiBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVuViecHauQuaThietHaiBus
		/// </summary>
		/// <returns>An instant of LqVuViecHauQuaThietHai class</returns>
		public static LqVuViecHauQuaThietHaiBus CreateInstant()
		{
			return new LqVuViecHauQuaThietHaiBus();
		}
	}
}
