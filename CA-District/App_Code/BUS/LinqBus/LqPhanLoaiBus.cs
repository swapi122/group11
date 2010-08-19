

/*
'===============================================================================
'  LinqHelper.BUS.LqPhanLoai
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
	public class LqPhanLoaiBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhanLoaiBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqPhanLoaiBus
		/// </summary>
		/// <returns>An instant of LqPhanLoai class</returns>
		public static LqPhanLoaiBus CreateInstant()
		{
			return new LqPhanLoaiBus();
		}
	}
}
