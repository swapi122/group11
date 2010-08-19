
/*
'===============================================================================
'  LinqHelper.DAO.LqKetQuaXuLy
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
	public class LqKetQuaXuLy : LqKetQuaXuLyBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqKetQuaXuLy()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqKetQuaXuLy
		/// </summary>
		/// <returns>An instant of LqKetQuaXuLy class</returns>
		public static LqKetQuaXuLy CreateInstant()
		{
			return new LqKetQuaXuLy();
		}
	}
}
