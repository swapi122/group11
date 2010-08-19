
/*
'===============================================================================
'  LinqHelper.DAO.LqTinh
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
	public class LqTinh : LqTinhBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinh()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTinh
		/// </summary>
		/// <returns>An instant of LqTinh class</returns>
		public static LqTinh CreateInstant()
		{
			return new LqTinh();
		}
	}
}
