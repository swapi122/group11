
/*
'===============================================================================
'  LinqHelper.DAO.LqKhoiToVuAn
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
	public class LqKhoiToVuAn : LqKhoiToVuAnBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqKhoiToVuAn()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqKhoiToVuAn
		/// </summary>
		/// <returns>An instant of LqKhoiToVuAn class</returns>
		public static LqKhoiToVuAn CreateInstant()
		{
			return new LqKhoiToVuAn();
		}
	}
}
