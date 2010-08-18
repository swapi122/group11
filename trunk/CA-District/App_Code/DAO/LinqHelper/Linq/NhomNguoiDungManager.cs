
/*
'===============================================================================
'  LinqHelper.DAO.LqNhomNguoiDung
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
	public class LqNhomNguoiDung : LqNhomNguoiDungBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNhomNguoiDung()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNhomNguoiDung
		/// </summary>
		/// <returns>An instant of LqNhomNguoiDung class</returns>
		public static LqNhomNguoiDung CreateInstant()
		{
			return new LqNhomNguoiDung();
		}
	}
}
