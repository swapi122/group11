

/*
'===============================================================================
'  LinqHelper.BUS.LqSoDoToChuc
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
	public class LqSoDoToChucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqSoDoToChucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqSoDoToChucBus
		/// </summary>
		/// <returns>An instant of LqSoDoToChuc class</returns>
		public static LqSoDoToChucBus CreateInstant()
		{
			return new LqSoDoToChucBus();
		}
	}
}
