

/*
'===============================================================================
'  LinqHelper.BUS.LqLoaiDiaBan
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
	public class LqLoaiDiaBanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiDiaBanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiDiaBanBus
		/// </summary>
		/// <returns>An instant of LqLoaiDiaBan class</returns>
		public static LqLoaiDiaBanBus CreateInstant()
		{
			return new LqLoaiDiaBanBus();
		}
	}
}
