
/*
'===============================================================================
'  LinqHelper.DAO.LqPhanLoai
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
	public class LqPhanLoai : LqPhanLoaiBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhanLoai()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqPhanLoai
		/// </summary>
		/// <returns>An instant of LqPhanLoai class</returns>
		public static LqPhanLoai CreateInstant()
		{
			return new LqPhanLoai();
		}
	}
}
