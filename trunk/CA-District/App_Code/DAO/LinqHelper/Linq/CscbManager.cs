
/*
'===============================================================================
'  LinqHelper.DAO.LqCscb
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
	public class LqCscb : LqCscbBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqCscb()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqCscb
		/// </summary>
		/// <returns>An instant of LqCscb class</returns>
		public static LqCscb CreateInstant()
		{
			return new LqCscb();
		}
	}
}
