
/*
'===============================================================================
'  LinqHelper.DAO.LqVuViecHauQuaThietHai
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqVuViecHauQuaThietHai : LqVuViecHauQuaThietHaiBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecHauQuaThietHai()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVuViecHauQuaThietHai
		/// </summary>
		/// <returns>An instant of LqVuViecHauQuaThietHai class</returns>
		public static LqVuViecHauQuaThietHai CreateInstant()
		{
			return new LqVuViecHauQuaThietHai();
		}
	}
}
