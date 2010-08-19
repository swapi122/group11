

/*
'===============================================================================
'  LinqHelper.BUS.LqNguonPhatHien
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
	public class LqNguonPhatHienBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNguonPhatHienBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNguonPhatHienBus
		/// </summary>
		/// <returns>An instant of LqNguonPhatHien class</returns>
		public static LqNguonPhatHienBus CreateInstant()
		{
			return new LqNguonPhatHienBus();
		}
	}
}
