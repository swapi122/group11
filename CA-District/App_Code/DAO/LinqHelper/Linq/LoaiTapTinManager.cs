
/*
'===============================================================================
'  LinqHelper.DAO.LqLoaiTapTin
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
	public class LqLoaiTapTin : LqLoaiTapTinBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiTapTin()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiTapTin
		/// </summary>
		/// <returns>An instant of LqLoaiTapTin class</returns>
		public static LqLoaiTapTin CreateInstant()
		{
			return new LqLoaiTapTin();
		}
	}
}
