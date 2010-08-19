
/*
'===============================================================================
'  LinqHelper.DAO.LqXuLyKhac
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
	public class LqXuLyKhac : LqXuLyKhacBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqXuLyKhac()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqXuLyKhac
		/// </summary>
		/// <returns>An instant of LqXuLyKhac class</returns>
		public static LqXuLyKhac CreateInstant()
		{
			return new LqXuLyKhac();
		}
	}
}
