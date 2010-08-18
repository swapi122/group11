
/*
'===============================================================================
'  LinqHelper.DAO.LqLoaiHoKhau
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
	public class LqLoaiHoKhau : LqLoaiHoKhauBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiHoKhau()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiHoKhau
		/// </summary>
		/// <returns>An instant of LqLoaiHoKhau class</returns>
		public static LqLoaiHoKhau CreateInstant()
		{
			return new LqLoaiHoKhau();
		}
	}
}
