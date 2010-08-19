

/*
'===============================================================================
'  LinqHelper.BUS.LqChucNangNhom
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
	public class LqChucNangNhomBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqChucNangNhomBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqChucNangNhomBus
		/// </summary>
		/// <returns>An instant of LqChucNangNhom class</returns>
		public static LqChucNangNhomBus CreateInstant()
		{
			return new LqChucNangNhomBus();
		}
	}
}
