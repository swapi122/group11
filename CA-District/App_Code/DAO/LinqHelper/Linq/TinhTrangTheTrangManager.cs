
/*
'===============================================================================
'  LinqHelper.DAO.LqTinhTrangTheTrang
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
	public class LqTinhTrangTheTrang : LqTinhTrangTheTrangBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhTrangTheTrang()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTinhTrangTheTrang
		/// </summary>
		/// <returns>An instant of LqTinhTrangTheTrang class</returns>
		public static LqTinhTrangTheTrang CreateInstant()
		{
			return new LqTinhTrangTheTrang();
		}
	}
}
