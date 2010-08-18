
/*
'===============================================================================
'  LinqHelper.DAO.LqChucNang
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
	public class LqChucNang : LqChucNangBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqChucNang()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqChucNang
		/// </summary>
		/// <returns>An instant of LqChucNang class</returns>
		public static LqChucNang CreateInstant()
		{
			return new LqChucNang();
		}
	}
}
