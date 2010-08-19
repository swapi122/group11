

/*
'===============================================================================
'  LinqHelper.BUS.LqDieuTraDiaBan
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
	public class LqDieuTraDiaBanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDieuTraDiaBanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDieuTraDiaBanBus
		/// </summary>
		/// <returns>An instant of LqDieuTraDiaBan class</returns>
		public static LqDieuTraDiaBanBus CreateInstant()
		{
			return new LqDieuTraDiaBanBus();
		}
	}
}
