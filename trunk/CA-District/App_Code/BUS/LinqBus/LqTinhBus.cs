

/*
'===============================================================================
'  LinqHelper.BUS.LqTinh
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
	public class LqTinhBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTinhBus
		/// </summary>
		/// <returns>An instant of LqTinh class</returns>
		public static LqTinhBus CreateInstant()
		{
			return new LqTinhBus();
		}
	}
}
