

/*
'===============================================================================
'  LinqHelper.BUS.LqPhanLoaiChuyenDe
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.BUS
{
	public class LqPhanLoaiChuyenDeBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhanLoaiChuyenDeBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqPhanLoaiChuyenDeBus
		/// </summary>
		/// <returns>An instant of LqPhanLoaiChuyenDe class</returns>
		public static LqPhanLoaiChuyenDeBus CreateInstant()
		{
			return new LqPhanLoaiChuyenDeBus();
		}
	}
}
