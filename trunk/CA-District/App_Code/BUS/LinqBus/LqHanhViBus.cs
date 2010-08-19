

/*
'===============================================================================
'  LinqHelper.BUS.LqHanhVi
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
	public class LqHanhViBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHanhViBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqHanhViBus
		/// </summary>
		/// <returns>An instant of LqHanhVi class</returns>
		public static LqHanhViBus CreateInstant()
		{
			return new LqHanhViBus();
		}
	}
}
