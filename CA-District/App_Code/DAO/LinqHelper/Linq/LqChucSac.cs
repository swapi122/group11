
/*
'===============================================================================
'  LinqHelper.DAO.LqChucSac
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
	public class LqChucSac : LqChucSacBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqChucSac()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqChucSac
		/// </summary>
		/// <returns>An instant of LqChucSac class</returns>
		public static LqChucSac CreateInstant()
		{
			return new LqChucSac();
		}
	}
}
