
/*
'===============================================================================
'  LinqHelper.DAO.LqVuViecDoiTuong
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
	public class LqVuViecDoiTuong : LqVuViecDoiTuongBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecDoiTuong()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVuViecDoiTuong
		/// </summary>
		/// <returns>An instant of LqVuViecDoiTuong class</returns>
		public static LqVuViecDoiTuong CreateInstant()
		{
			return new LqVuViecDoiTuong();
		}
	}
}
