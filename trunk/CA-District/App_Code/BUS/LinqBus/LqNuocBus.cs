

/*
'===============================================================================
'  LinqHelper.BUS.LqNuoc
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
	public class LqNuocBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNuocBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNuocBus
		/// </summary>
		/// <returns>An instant of LqNuoc class</returns>
		public static LqNuocBus CreateInstant()
		{
			return new LqNuocBus();
		}
	}
}
