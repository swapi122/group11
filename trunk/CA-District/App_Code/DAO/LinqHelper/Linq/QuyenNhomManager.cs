
/*
'===============================================================================
'  LinqHelper.DAO.LqQuyenNhom
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
	public class LqQuyenNhom : LqQuyenNhomBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqQuyenNhom()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqQuyenNhom
		/// </summary>
		/// <returns>An instant of LqQuyenNhom class</returns>
		public static LqQuyenNhom CreateInstant()
		{
			return new LqQuyenNhom();
		}
	}
}
