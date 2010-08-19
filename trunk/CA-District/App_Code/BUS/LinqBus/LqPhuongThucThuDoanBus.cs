

/*
'===============================================================================
'  LinqHelper.BUS.LqPhuongThucThuDoan
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
	public class LqPhuongThucThuDoanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhuongThucThuDoanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqPhuongThucThuDoanBus
		/// </summary>
		/// <returns>An instant of LqPhuongThucThuDoan class</returns>
		public static LqPhuongThucThuDoanBus CreateInstant()
		{
			return new LqPhuongThucThuDoanBus();
		}
	}
}
