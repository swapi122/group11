

/*
'===============================================================================
'  LinqHelper.BUS.LqTonGiao
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
	public class LqTonGiaoBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTonGiaoBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTonGiaoBus
		/// </summary>
		/// <returns>An instant of LqTonGiao class</returns>
		public static LqTonGiaoBus CreateInstant()
		{
			return new LqTonGiaoBus();
		}
	}
}
