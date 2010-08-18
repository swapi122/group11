
/*
'===============================================================================
'  LinqHelper.DAO.LqDanToc
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
	public class LqDanToc : LqDanTocBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDanToc()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDanToc
		/// </summary>
		/// <returns>An instant of LqDanToc class</returns>
		public static LqDanToc CreateInstant()
		{
			return new LqDanToc();
		}
	}
}
