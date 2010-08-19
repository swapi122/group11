

/*
'===============================================================================
'  LinqHelper.BUS.LqCscb
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
	public class LqCscbBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqCscbBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqCscbBus
		/// </summary>
		/// <returns>An instant of LqCscb class</returns>
		public static LqCscbBus CreateInstant()
		{
			return new LqCscbBus();
		}
	}
}
