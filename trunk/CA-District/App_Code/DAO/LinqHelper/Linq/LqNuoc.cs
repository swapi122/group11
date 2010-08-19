
/*
'===============================================================================
'  LinqHelper.DAO.LqNuoc
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
	public class LqNuoc : LqNuocBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNuoc()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNuoc
		/// </summary>
		/// <returns>An instant of LqNuoc class</returns>
		public static LqNuoc CreateInstant()
		{
			return new LqNuoc();
		}
	}
}
