

/*
'===============================================================================
'  LinqHelper.BUS.LqTrinhDoHocVan
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
	public class LqTrinhDoHocVanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTrinhDoHocVanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTrinhDoHocVanBus
		/// </summary>
		/// <returns>An instant of LqTrinhDoHocVan class</returns>
		public static LqTrinhDoHocVanBus CreateInstant()
		{
			return new LqTrinhDoHocVanBus();
		}
	}
}
