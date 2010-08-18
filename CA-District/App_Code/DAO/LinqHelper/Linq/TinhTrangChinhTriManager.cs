
/*
'===============================================================================
'  LinqHelper.DAO.LqTinhTrangChinhTri
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
	public class LqTinhTrangChinhTri : LqTinhTrangChinhTriBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhTrangChinhTri()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTinhTrangChinhTri
		/// </summary>
		/// <returns>An instant of LqTinhTrangChinhTri class</returns>
		public static LqTinhTrangChinhTri CreateInstant()
		{
			return new LqTinhTrangChinhTri();
		}
	}
}
