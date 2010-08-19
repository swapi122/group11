

/*
'===============================================================================
'  LinqHelper.BUS.LqPhanLoaiDiaBan
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
	public class LqPhanLoaiDiaBanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhanLoaiDiaBanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqPhanLoaiDiaBanBus
		/// </summary>
		/// <returns>An instant of LqPhanLoaiDiaBan class</returns>
		public static LqPhanLoaiDiaBanBus CreateInstant()
		{
			return new LqPhanLoaiDiaBanBus();
		}
	}
}
