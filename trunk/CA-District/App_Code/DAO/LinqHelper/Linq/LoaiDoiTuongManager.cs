
/*
'===============================================================================
'  LinqHelper.DAO.LqLoaiDoiTuong
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
	public class LqLoaiDoiTuong : LqLoaiDoiTuongBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiDoiTuong()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiDoiTuong
		/// </summary>
		/// <returns>An instant of LqLoaiDoiTuong class</returns>
		public static LqLoaiDoiTuong CreateInstant()
		{
			return new LqLoaiDoiTuong();
		}
	}
}
