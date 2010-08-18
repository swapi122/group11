
/*
'===============================================================================
'  LinqHelper.DAO.LqChucVu
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
	public class LqChucVu : LqChucVuBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqChucVu()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqChucVu
		/// </summary>
		/// <returns>An instant of LqChucVu class</returns>
		public static LqChucVu CreateInstant()
		{
			return new LqChucVu();
		}
	}
}
