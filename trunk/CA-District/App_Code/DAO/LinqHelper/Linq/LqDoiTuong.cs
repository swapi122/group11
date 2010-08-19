
/*
'===============================================================================
'  LinqHelper.DAO.LqDoiTuong
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
	public class LqDoiTuong : LqDoiTuongBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDoiTuong()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDoiTuong
		/// </summary>
		/// <returns>An instant of LqDoiTuong class</returns>
		public static LqDoiTuong CreateInstant()
		{
			return new LqDoiTuong();
		}
	}
}
