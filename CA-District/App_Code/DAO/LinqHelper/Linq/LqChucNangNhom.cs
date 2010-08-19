
/*
'===============================================================================
'  LinqHelper.DAO.LqChucNangNhom
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
	public class LqChucNangNhom : LqChucNangNhomBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqChucNangNhom()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqChucNangNhom
		/// </summary>
		/// <returns>An instant of LqChucNangNhom class</returns>
		public static LqChucNangNhom CreateInstant()
		{
			return new LqChucNangNhom();
		}
	}
}
