

/*
'===============================================================================
'  LinqHelper.BUS.LqKhamPha
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
	public class LqKhamPhaBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqKhamPhaBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqKhamPhaBus
		/// </summary>
		/// <returns>An instant of LqKhamPha class</returns>
		public static LqKhamPhaBus CreateInstant()
		{
			return new LqKhamPhaBus();
		}
	}
}
