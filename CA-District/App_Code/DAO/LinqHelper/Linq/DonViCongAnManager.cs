
/*
'===============================================================================
'  LinqHelper.DAO.LqDonViCongAn
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
	public class LqDonViCongAn : LqDonViCongAnBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDonViCongAn()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDonViCongAn
		/// </summary>
		/// <returns>An instant of LqDonViCongAn class</returns>
		public static LqDonViCongAn CreateInstant()
		{
			return new LqDonViCongAn();
		}
	}
}
