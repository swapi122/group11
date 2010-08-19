

/*
'===============================================================================
'  LinqHelper.BUS.LqKetQuaXuLy
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
	public class LqKetQuaXuLyBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqKetQuaXuLyBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqKetQuaXuLyBus
		/// </summary>
		/// <returns>An instant of LqKetQuaXuLy class</returns>
		public static LqKetQuaXuLyBus CreateInstant()
		{
			return new LqKetQuaXuLyBus();
		}
	}
}
