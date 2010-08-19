
/*
'===============================================================================
'  LinqHelper.DAO.LqDanhGiaTin
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
	public class LqDanhGiaTin : LqDanhGiaTinBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDanhGiaTin()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDanhGiaTin
		/// </summary>
		/// <returns>An instant of LqDanhGiaTin class</returns>
		public static LqDanhGiaTin CreateInstant()
		{
			return new LqDanhGiaTin();
		}
	}
}
