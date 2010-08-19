

/*
'===============================================================================
'  LinqHelper.BUS.LqDanToc
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.BUS
{
	public class LqDanTocBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDanTocBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDanTocBus
		/// </summary>
		/// <returns>An instant of LqDanToc class</returns>
		public static LqDanTocBus CreateInstant()
		{
			return new LqDanTocBus();
		}
	}
}
