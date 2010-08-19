

/*
'===============================================================================
'  LinqHelper.BUS.LqXuLyKhac
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
	public class LqXuLyKhacBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqXuLyKhacBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqXuLyKhacBus
		/// </summary>
		/// <returns>An instant of LqXuLyKhac class</returns>
		public static LqXuLyKhacBus CreateInstant()
		{
			return new LqXuLyKhacBus();
		}
	}
}
