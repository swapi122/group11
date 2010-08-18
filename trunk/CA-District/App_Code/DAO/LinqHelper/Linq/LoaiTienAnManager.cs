
/*
'===============================================================================
'  LinqHelper.DAO.LqLoaiTienAn
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
	public class LqLoaiTienAn : LqLoaiTienAnBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiTienAn()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiTienAn
		/// </summary>
		/// <returns>An instant of LqLoaiTienAn class</returns>
		public static LqLoaiTienAn CreateInstant()
		{
			return new LqLoaiTienAn();
		}
	}
}
