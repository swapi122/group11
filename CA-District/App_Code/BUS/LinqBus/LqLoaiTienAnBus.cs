

/*
'===============================================================================
'  LinqHelper.BUS.LqLoaiTienAn
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
	public class LqLoaiTienAnBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiTienAnBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiTienAnBus
		/// </summary>
		/// <returns>An instant of LqLoaiTienAn class</returns>
		public static LqLoaiTienAnBus CreateInstant()
		{
			return new LqLoaiTienAnBus();
		}
	}
}
