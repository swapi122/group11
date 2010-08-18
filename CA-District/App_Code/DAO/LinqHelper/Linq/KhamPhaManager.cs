
/*
'===============================================================================
'  LinqHelper.DAO.LqKhamPha
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
	public class LqKhamPha : LqKhamPhaBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqKhamPha()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqKhamPha
		/// </summary>
		/// <returns>An instant of LqKhamPha class</returns>
		public static LqKhamPha CreateInstant()
		{
			return new LqKhamPha();
		}
	}
}
