
/*
'===============================================================================
'  LinqHelper.DAO.LqVaiTroTrongVuAn
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqVaiTroTrongVuAn : LqVaiTroTrongVuAnBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVaiTroTrongVuAn()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVaiTroTrongVuAn
		/// </summary>
		/// <returns>An instant of LqVaiTroTrongVuAn class</returns>
		public static LqVaiTroTrongVuAn CreateInstant()
		{
			return new LqVaiTroTrongVuAn();
		}
	}
}
