
/*
'===============================================================================
'  LinqHelper.DAO.LqHoKhau
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
	public class LqHoKhau : LqHoKhauBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHoKhau()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqHoKhau
		/// </summary>
		/// <returns>An instant of LqHoKhau class</returns>
		public static LqHoKhau CreateInstant()
		{
			return new LqHoKhau();
		}
	}
}
