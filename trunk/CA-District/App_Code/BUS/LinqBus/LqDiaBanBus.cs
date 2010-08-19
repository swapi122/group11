

/*
'===============================================================================
'  LinqHelper.BUS.LqDiaBan
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
	public class LqDiaBanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDiaBanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDiaBanBus
		/// </summary>
		/// <returns>An instant of LqDiaBan class</returns>
		public static LqDiaBanBus CreateInstant()
		{
			return new LqDiaBanBus();
		}
	}
}
