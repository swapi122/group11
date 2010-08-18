
/*
'===============================================================================
'  LinqHelper.DAO.LqXuLyHanhChinh
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
	public class LqXuLyHanhChinh : LqXuLyHanhChinhBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqXuLyHanhChinh()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqXuLyHanhChinh
		/// </summary>
		/// <returns>An instant of LqXuLyHanhChinh class</returns>
		public static LqXuLyHanhChinh CreateInstant()
		{
			return new LqXuLyHanhChinh();
		}
	}
}
