
/*
'===============================================================================
'  LinqHelper.DAO.LqNguonPhatHien
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
	public class LqNguonPhatHien : LqNguonPhatHienBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNguonPhatHien()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNguonPhatHien
		/// </summary>
		/// <returns>An instant of LqNguonPhatHien class</returns>
		public static LqNguonPhatHien CreateInstant()
		{
			return new LqNguonPhatHien();
		}
	}
}
