
/*
'===============================================================================
'  LinqHelper.DAO.LqXa
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
	public class LqXa : LqXaBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqXa()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqXa
		/// </summary>
		/// <returns>An instant of LqXa class</returns>
		public static LqXa CreateInstant()
		{
			return new LqXa();
		}
	}
}
