
/*
'===============================================================================
'  LinqHelper.DAO.LqDoiTuongToChuc
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
	public class LqDoiTuongToChuc : LqDoiTuongToChucBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDoiTuongToChuc()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDoiTuongToChuc
		/// </summary>
		/// <returns>An instant of LqDoiTuongToChuc class</returns>
		public static LqDoiTuongToChuc CreateInstant()
		{
			return new LqDoiTuongToChuc();
		}
	}
}
