
/*
'===============================================================================
'  LinqHelper.DAO.LqHuyen
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
	public class LqHuyen : LqHuyenBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHuyen()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqHuyen
		/// </summary>
		/// <returns>An instant of LqHuyen class</returns>
		public static LqHuyen CreateInstant()
		{
			return new LqHuyen();
		}
	}
}
