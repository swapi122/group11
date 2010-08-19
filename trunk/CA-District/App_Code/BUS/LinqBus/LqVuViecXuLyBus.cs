

/*
'===============================================================================
'  LinqHelper.BUS.LqVuViecXuLy
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
	public class LqVuViecXuLyBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecXuLyBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVuViecXuLyBus
		/// </summary>
		/// <returns>An instant of LqVuViecXuLy class</returns>
		public static LqVuViecXuLyBus CreateInstant()
		{
			return new LqVuViecXuLyBus();
		}
	}
}
