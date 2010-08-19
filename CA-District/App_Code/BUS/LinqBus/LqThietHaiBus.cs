

/*
'===============================================================================
'  LinqHelper.BUS.LqThietHai
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
	public class LqThietHaiBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqThietHaiBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqThietHaiBus
		/// </summary>
		/// <returns>An instant of LqThietHai class</returns>
		public static LqThietHaiBus CreateInstant()
		{
			return new LqThietHaiBus();
		}
	}
}
