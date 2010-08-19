

/*
'===============================================================================
'  LinqHelper.BUS.LqDanhMucTin
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
	public class LqDanhMucTinBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDanhMucTinBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDanhMucTinBus
		/// </summary>
		/// <returns>An instant of LqDanhMucTin class</returns>
		public static LqDanhMucTinBus CreateInstant()
		{
			return new LqDanhMucTinBus();
		}
	}
}
