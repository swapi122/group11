
/*
'===============================================================================
'  LinqHelper.DAO.LqNanNhan
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
	public class LqNanNhan : LqNanNhanBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNanNhan()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNanNhan
		/// </summary>
		/// <returns>An instant of LqNanNhan class</returns>
		public static LqNanNhan CreateInstant()
		{
			return new LqNanNhan();
		}
	}
}
