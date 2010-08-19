

/*
'===============================================================================
'  LinqHelper.BUS.LqOkhuVuc
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
	public class LqOkhuVucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqOkhuVucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqOkhuVucBus
		/// </summary>
		/// <returns>An instant of LqOkhuVuc class</returns>
		public static LqOkhuVucBus CreateInstant()
		{
			return new LqOkhuVucBus();
		}
	}
}
