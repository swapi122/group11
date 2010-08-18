
/*
'===============================================================================
'  LinqHelper.DAO.LqDieuTraToChuc
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
	public class LqDieuTraToChuc : LqDieuTraToChucBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDieuTraToChuc()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDieuTraToChuc
		/// </summary>
		/// <returns>An instant of LqDieuTraToChuc class</returns>
		public static LqDieuTraToChuc CreateInstant()
		{
			return new LqDieuTraToChuc();
		}
	}
}
