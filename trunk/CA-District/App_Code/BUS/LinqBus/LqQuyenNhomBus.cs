

/*
'===============================================================================
'  LinqHelper.BUS.LqQuyenNhom
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
	public class LqQuyenNhomBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqQuyenNhomBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqQuyenNhomBus
		/// </summary>
		/// <returns>An instant of LqQuyenNhom class</returns>
		public static LqQuyenNhomBus CreateInstant()
		{
			return new LqQuyenNhomBus();
		}
	}
}
