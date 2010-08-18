
/*
'===============================================================================
'  LinqHelper.DAO.LqOkhuVuc
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
	public class LqOkhuVuc : LqOkhuVucBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqOkhuVuc()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqOkhuVuc
		/// </summary>
		/// <returns>An instant of LqOkhuVuc class</returns>
		public static LqOkhuVuc CreateInstant()
		{
			return new LqOkhuVuc();
		}
	}
}
