
/*
'===============================================================================
'  LinqHelper.DAO.LqTienSuDoiTuong
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
	public class LqTienSuDoiTuong : LqTienSuDoiTuongBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTienSuDoiTuong()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTienSuDoiTuong
		/// </summary>
		/// <returns>An instant of LqTienSuDoiTuong class</returns>
		public static LqTienSuDoiTuong CreateInstant()
		{
			return new LqTienSuDoiTuong();
		}
	}
}
