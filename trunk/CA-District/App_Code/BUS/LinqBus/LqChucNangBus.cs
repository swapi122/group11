

/*
'===============================================================================
'  LinqHelper.BUS.LqChucNang
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
	public class LqChucNangBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqChucNangBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqChucNangBus
		/// </summary>
		/// <returns>An instant of LqChucNang class</returns>
		public static LqChucNangBus CreateInstant()
		{
			return new LqChucNangBus();
		}
	}
}
