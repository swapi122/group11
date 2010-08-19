

/*
'===============================================================================
'  LinqHelper.BUS.LqNhomNguoiDung
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
	public class LqNhomNguoiDungBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNhomNguoiDungBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNhomNguoiDungBus
		/// </summary>
		/// <returns>An instant of LqNhomNguoiDung class</returns>
		public static LqNhomNguoiDungBus CreateInstant()
		{
			return new LqNhomNguoiDungBus();
		}
	}
}
