

/*
'===============================================================================
'  LinqHelper.BUS.LqNgheNghiep
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
	public class LqNgheNghiepBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNgheNghiepBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNgheNghiepBus
		/// </summary>
		/// <returns>An instant of LqNgheNghiep class</returns>
		public static LqNgheNghiepBus CreateInstant()
		{
			return new LqNgheNghiepBus();
		}
	}
}
