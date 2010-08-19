
/*
'===============================================================================
'  LinqHelper.DAO.LqPhanLoaiChuyenDe
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
	public class LqPhanLoaiChuyenDe : LqPhanLoaiChuyenDeBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhanLoaiChuyenDe()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqPhanLoaiChuyenDe
		/// </summary>
		/// <returns>An instant of LqPhanLoaiChuyenDe class</returns>
		public static LqPhanLoaiChuyenDe CreateInstant()
		{
			return new LqPhanLoaiChuyenDe();
		}
	}
}
