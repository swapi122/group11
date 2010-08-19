

/*
'===============================================================================
'  LinqHelper.BUS.LqNguoiDungVaNhom
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
	public class LqNguoiDungVaNhomBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNguoiDungVaNhomBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNguoiDungVaNhomBus
		/// </summary>
		/// <returns>An instant of LqNguoiDungVaNhom class</returns>
		public static LqNguoiDungVaNhomBus CreateInstant()
		{
			return new LqNguoiDungVaNhomBus();
		}
	}
}
