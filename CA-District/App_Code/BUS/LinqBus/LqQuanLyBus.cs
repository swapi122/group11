

/*
'===============================================================================
'  LinqHelper.BUS.LqQuanLy
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
	public class LqQuanLyBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqQuanLyBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqQuanLyBus
		/// </summary>
		/// <returns>An instant of LqQuanLy class</returns>
		public static LqQuanLyBus CreateInstant()
		{
			return new LqQuanLyBus();
		}
	}
}
