

/*
'===============================================================================
'  LinqHelper.BUS.LqTapTinDinhKem
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
	public class LqTapTinDinhKemBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTapTinDinhKemBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTapTinDinhKemBus
		/// </summary>
		/// <returns>An instant of LqTapTinDinhKem class</returns>
		public static LqTapTinDinhKemBus CreateInstant()
		{
			return new LqTapTinDinhKemBus();
		}
	}
}
