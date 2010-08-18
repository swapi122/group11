
/*
'===============================================================================
'  LinqHelper.DAO.LqQuanLy
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
	public class LqQuanLy : LqQuanLyBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqQuanLy()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqQuanLy
		/// </summary>
		/// <returns>An instant of LqQuanLy class</returns>
		public static LqQuanLy CreateInstant()
		{
			return new LqQuanLy();
		}
	}
}
