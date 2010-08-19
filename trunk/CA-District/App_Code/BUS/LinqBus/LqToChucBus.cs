

/*
'===============================================================================
'  LinqHelper.BUS.LqToChuc
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
	public class LqToChucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqToChucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqToChucBus
		/// </summary>
		/// <returns>An instant of LqToChuc class</returns>
		public static LqToChucBus CreateInstant()
		{
			return new LqToChucBus();
		}
	}
}
