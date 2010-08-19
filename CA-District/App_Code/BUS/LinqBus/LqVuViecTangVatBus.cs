

/*
'===============================================================================
'  LinqHelper.BUS.LqVuViecTangVat
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
	public class LqVuViecTangVatBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecTangVatBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVuViecTangVatBus
		/// </summary>
		/// <returns>An instant of LqVuViecTangVat class</returns>
		public static LqVuViecTangVatBus CreateInstant()
		{
			return new LqVuViecTangVatBus();
		}
	}
}
