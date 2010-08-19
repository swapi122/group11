

/*
'===============================================================================
'  LinqHelper.BUS.LqXa
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
	public class LqXaBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqXaBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqXaBus
		/// </summary>
		/// <returns>An instant of LqXa class</returns>
		public static LqXaBus CreateInstant()
		{
			return new LqXaBus();
		}
	}
}
