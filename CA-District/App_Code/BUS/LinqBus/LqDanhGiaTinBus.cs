

/*
'===============================================================================
'  LinqHelper.BUS.LqDanhGiaTin
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
	public class LqDanhGiaTinBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDanhGiaTinBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDanhGiaTinBus
		/// </summary>
		/// <returns>An instant of LqDanhGiaTin class</returns>
		public static LqDanhGiaTinBus CreateInstant()
		{
			return new LqDanhGiaTinBus();
		}
	}
}
