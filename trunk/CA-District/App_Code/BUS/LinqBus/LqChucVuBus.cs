

/*
'===============================================================================
'  LinqHelper.BUS.LqChucVu
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
	public class LqChucVuBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqChucVuBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqChucVuBus
		/// </summary>
		/// <returns>An instant of LqChucVu class</returns>
		public static LqChucVuBus CreateInstant()
		{
			return new LqChucVuBus();
		}
	}
}
