
/*
'===============================================================================
'  LinqHelper.DAO.LqKiemDien
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
	public class LqKiemDien : LqKiemDienBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqKiemDien()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqKiemDien
		/// </summary>
		/// <returns>An instant of LqKiemDien class</returns>
		public static LqKiemDien CreateInstant()
		{
			return new LqKiemDien();
		}
	}
}
