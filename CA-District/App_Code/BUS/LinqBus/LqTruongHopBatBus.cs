

/*
'===============================================================================
'  LinqHelper.BUS.LqTruongHopBat
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
	public class LqTruongHopBatBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTruongHopBatBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTruongHopBatBus
		/// </summary>
		/// <returns>An instant of LqTruongHopBat class</returns>
		public static LqTruongHopBatBus CreateInstant()
		{
			return new LqTruongHopBatBus();
		}
	}
}
