
/*
'===============================================================================
'  LinqHelper.DAO.LqHanhVi
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
	public class LqHanhVi : LqHanhViBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHanhVi()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqHanhVi
		/// </summary>
		/// <returns>An instant of LqHanhVi class</returns>
		public static LqHanhVi CreateInstant()
		{
			return new LqHanhVi();
		}
	}
}
