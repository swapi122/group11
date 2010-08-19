

/*
'===============================================================================
'  LinqHelper.BUS.LqLoaiCoQuan
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
	public class LqLoaiCoQuanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiCoQuanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiCoQuanBus
		/// </summary>
		/// <returns>An instant of LqLoaiCoQuan class</returns>
		public static LqLoaiCoQuanBus CreateInstant()
		{
			return new LqLoaiCoQuanBus();
		}
	}
}
