
/*
'===============================================================================
'  LinqHelper.DAO.LqThongTinBat
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
	public class LqThongTinBat : LqThongTinBatBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqThongTinBat()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqThongTinBat
		/// </summary>
		/// <returns>An instant of LqThongTinBat class</returns>
		public static LqThongTinBat CreateInstant()
		{
			return new LqThongTinBat();
		}
	}
}
