
/*
'===============================================================================
'  LinqHelper.DAO.LqLoaiTien
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
	public class LqLoaiTien : LqLoaiTienBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiTien()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiTien
		/// </summary>
		/// <returns>An instant of LqLoaiTien class</returns>
		public static LqLoaiTien CreateInstant()
		{
			return new LqLoaiTien();
		}
	}
}
