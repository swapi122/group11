

/*
'===============================================================================
'  LinqHelper.BUS.LqNanNhan
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
	public class LqNanNhanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNanNhanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNanNhanBus
		/// </summary>
		/// <returns>An instant of LqNanNhan class</returns>
		public static LqNanNhanBus CreateInstant()
		{
			return new LqNanNhanBus();
		}
	}
}
