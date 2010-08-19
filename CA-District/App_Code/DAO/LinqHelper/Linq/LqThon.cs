
/*
'===============================================================================
'  LinqHelper.DAO.LqThon
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
	public class LqThon : LqThonBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqThon()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqThon
		/// </summary>
		/// <returns>An instant of LqThon class</returns>
		public static LqThon CreateInstant()
		{
			return new LqThon();
		}
	}
}
