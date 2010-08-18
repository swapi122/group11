
/*
'===============================================================================
'  LinqHelper.DAO.LqTapTinDinhKem
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
	public class LqTapTinDinhKem : LqTapTinDinhKemBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTapTinDinhKem()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTapTinDinhKem
		/// </summary>
		/// <returns>An instant of LqTapTinDinhKem class</returns>
		public static LqTapTinDinhKem CreateInstant()
		{
			return new LqTapTinDinhKem();
		}
	}
}
