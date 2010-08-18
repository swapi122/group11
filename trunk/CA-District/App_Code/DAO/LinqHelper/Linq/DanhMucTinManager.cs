
/*
'===============================================================================
'  LinqHelper.DAO.LqDanhMucTin
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
	public class LqDanhMucTin : LqDanhMucTinBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDanhMucTin()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDanhMucTin
		/// </summary>
		/// <returns>An instant of LqDanhMucTin class</returns>
		public static LqDanhMucTin CreateInstant()
		{
			return new LqDanhMucTin();
		}
	}
}
