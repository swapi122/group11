
/*
'===============================================================================
'  LinqHelper.DAO.LqPhanLoaiDoiTuong
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
	public class LqPhanLoaiDoiTuong : LqPhanLoaiDoiTuongBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhanLoaiDoiTuong()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqPhanLoaiDoiTuong
		/// </summary>
		/// <returns>An instant of LqPhanLoaiDoiTuong class</returns>
		public static LqPhanLoaiDoiTuong CreateInstant()
		{
			return new LqPhanLoaiDoiTuong();
		}
	}
}
