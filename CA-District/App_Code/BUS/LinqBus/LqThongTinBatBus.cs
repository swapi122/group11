

/*
'===============================================================================
'  LinqHelper.BUS.LqThongTinBat
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
	public class LqThongTinBatBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqThongTinBatBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqThongTinBatBus
		/// </summary>
		/// <returns>An instant of LqThongTinBat class</returns>
		public static LqThongTinBatBus CreateInstant()
		{
			return new LqThongTinBatBus();
		}
	}
}
