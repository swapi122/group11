

/*
'===============================================================================
'  LinqHelper.BUS.LqDoiTuongToChuc
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.BUS
{
	public class LqDoiTuongToChucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDoiTuongToChucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDoiTuongToChucBus
		/// </summary>
		/// <returns>An instant of LqDoiTuongToChuc class</returns>
		public static LqDoiTuongToChucBus CreateInstant()
		{
			return new LqDoiTuongToChucBus();
		}
	}
}
