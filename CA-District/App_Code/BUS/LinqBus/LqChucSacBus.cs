

/*
'===============================================================================
'  LinqHelper.BUS.LqChucSac
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
	public class LqChucSacBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqChucSacBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqChucSacBus
		/// </summary>
		/// <returns>An instant of LqChucSac class</returns>
		public static LqChucSacBus CreateInstant()
		{
			return new LqChucSacBus();
		}
	}
}
