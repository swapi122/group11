
/*
'===============================================================================
'  LinqHelper.DAO.LqToDanPho
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
	public class LqToDanPho : LqToDanPhoBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqToDanPho()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqToDanPho
		/// </summary>
		/// <returns>An instant of LqToDanPho class</returns>
		public static LqToDanPho CreateInstant()
		{
			return new LqToDanPho();
		}
	}
}
