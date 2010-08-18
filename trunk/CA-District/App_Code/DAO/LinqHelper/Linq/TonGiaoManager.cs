
/*
'===============================================================================
'  LinqHelper.DAO.LqTonGiao
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
	public class LqTonGiao : LqTonGiaoBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTonGiao()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTonGiao
		/// </summary>
		/// <returns>An instant of LqTonGiao class</returns>
		public static LqTonGiao CreateInstant()
		{
			return new LqTonGiao();
		}
	}
}
