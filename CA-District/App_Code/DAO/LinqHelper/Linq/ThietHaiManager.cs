
/*
'===============================================================================
'  LinqHelper.DAO.LqThietHai
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
	public class LqThietHai : LqThietHaiBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqThietHai()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqThietHai
		/// </summary>
		/// <returns>An instant of LqThietHai class</returns>
		public static LqThietHai CreateInstant()
		{
			return new LqThietHai();
		}
	}
}
