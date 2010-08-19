

/*
'===============================================================================
'  LinqHelper.BUS.LqHuyen
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
	public class LqHuyenBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHuyenBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqHuyenBus
		/// </summary>
		/// <returns>An instant of LqHuyen class</returns>
		public static LqHuyenBus CreateInstant()
		{
			return new LqHuyenBus();
		}
	}
}
