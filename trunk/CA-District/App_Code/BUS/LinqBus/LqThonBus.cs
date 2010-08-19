

/*
'===============================================================================
'  LinqHelper.BUS.LqThon
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
	public class LqThonBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqThonBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqThonBus
		/// </summary>
		/// <returns>An instant of LqThon class</returns>
		public static LqThonBus CreateInstant()
		{
			return new LqThonBus();
		}
	}
}
