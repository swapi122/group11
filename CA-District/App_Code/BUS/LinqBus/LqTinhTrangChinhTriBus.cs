

/*
'===============================================================================
'  LinqHelper.BUS.LqTinhTrangChinhTri
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
	public class LqTinhTrangChinhTriBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhTrangChinhTriBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTinhTrangChinhTriBus
		/// </summary>
		/// <returns>An instant of LqTinhTrangChinhTri class</returns>
		public static LqTinhTrangChinhTriBus CreateInstant()
		{
			return new LqTinhTrangChinhTriBus();
		}
	}
}
