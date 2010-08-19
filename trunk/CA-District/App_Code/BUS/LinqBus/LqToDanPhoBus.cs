

/*
'===============================================================================
'  LinqHelper.BUS.LqToDanPho
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
	public class LqToDanPhoBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqToDanPhoBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqToDanPhoBus
		/// </summary>
		/// <returns>An instant of LqToDanPho class</returns>
		public static LqToDanPhoBus CreateInstant()
		{
			return new LqToDanPhoBus();
		}
	}
}
