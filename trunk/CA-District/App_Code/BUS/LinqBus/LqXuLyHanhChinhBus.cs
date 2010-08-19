

/*
'===============================================================================
'  LinqHelper.BUS.LqXuLyHanhChinh
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
	public class LqXuLyHanhChinhBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqXuLyHanhChinhBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqXuLyHanhChinhBus
		/// </summary>
		/// <returns>An instant of LqXuLyHanhChinh class</returns>
		public static LqXuLyHanhChinhBus CreateInstant()
		{
			return new LqXuLyHanhChinhBus();
		}
	}
}
