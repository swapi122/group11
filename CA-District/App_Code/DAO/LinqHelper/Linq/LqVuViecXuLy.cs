
/*
'===============================================================================
'  LinqHelper.DAO.LqVuViecXuLy
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
	public class LqVuViecXuLy : LqVuViecXuLyBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecXuLy()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVuViecXuLy
		/// </summary>
		/// <returns>An instant of LqVuViecXuLy class</returns>
		public static LqVuViecXuLy CreateInstant()
		{
			return new LqVuViecXuLy();
		}
	}
}
