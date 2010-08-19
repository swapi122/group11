

/*
'===============================================================================
'  LinqHelper.BUS.LqCoToChuc
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
	public class LqCoToChucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqCoToChucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqCoToChucBus
		/// </summary>
		/// <returns>An instant of LqCoToChuc class</returns>
		public static LqCoToChucBus CreateInstant()
		{
			return new LqCoToChucBus();
		}
	}
}
