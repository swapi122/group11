

/*
'===============================================================================
'  LinqHelper.BUS.LqTangVat
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
	public class LqTangVatBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTangVatBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTangVatBus
		/// </summary>
		/// <returns>An instant of LqTangVat class</returns>
		public static LqTangVatBus CreateInstant()
		{
			return new LqTangVatBus();
		}
	}
}
