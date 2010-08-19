

/*
'===============================================================================
'  LinqHelper.BUS.LqVaiTroTrongVuAn
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
	public class LqVaiTroTrongVuAnBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVaiTroTrongVuAnBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVaiTroTrongVuAnBus
		/// </summary>
		/// <returns>An instant of LqVaiTroTrongVuAn class</returns>
		public static LqVaiTroTrongVuAnBus CreateInstant()
		{
			return new LqVaiTroTrongVuAnBus();
		}
	}
}
