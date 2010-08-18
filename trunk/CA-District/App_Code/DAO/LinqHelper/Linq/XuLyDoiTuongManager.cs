
/*
'===============================================================================
'  LinqHelper.DAO.LqXuLyDoiTuong
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
	public class LqXuLyDoiTuong : LqXuLyDoiTuongBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqXuLyDoiTuong()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqXuLyDoiTuong
		/// </summary>
		/// <returns>An instant of LqXuLyDoiTuong class</returns>
		public static LqXuLyDoiTuong CreateInstant()
		{
			return new LqXuLyDoiTuong();
		}
	}
}
