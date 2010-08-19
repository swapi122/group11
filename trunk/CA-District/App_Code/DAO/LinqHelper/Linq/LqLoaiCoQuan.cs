
/*
'===============================================================================
'  LinqHelper.DAO.LqLoaiCoQuan
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
	public class LqLoaiCoQuan : LqLoaiCoQuanBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiCoQuan()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiCoQuan
		/// </summary>
		/// <returns>An instant of LqLoaiCoQuan class</returns>
		public static LqLoaiCoQuan CreateInstant()
		{
			return new LqLoaiCoQuan();
		}
	}
}
