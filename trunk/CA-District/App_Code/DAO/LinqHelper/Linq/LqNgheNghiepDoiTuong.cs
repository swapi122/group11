
/*
'===============================================================================
'  LinqHelper.DAO.LqNgheNghiepDoiTuong
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
	public class LqNgheNghiepDoiTuong : LqNgheNghiepDoiTuongBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNgheNghiepDoiTuong()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNgheNghiepDoiTuong
		/// </summary>
		/// <returns>An instant of LqNgheNghiepDoiTuong class</returns>
		public static LqNgheNghiepDoiTuong CreateInstant()
		{
			return new LqNgheNghiepDoiTuong();
		}
	}
}
