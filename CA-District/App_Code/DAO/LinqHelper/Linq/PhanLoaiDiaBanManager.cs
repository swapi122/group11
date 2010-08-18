
/*
'===============================================================================
'  LinqHelper.DAO.LqPhanLoaiDiaBan
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqPhanLoaiDiaBan : LqPhanLoaiDiaBanBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhanLoaiDiaBan()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqPhanLoaiDiaBan
		/// </summary>
		/// <returns>An instant of LqPhanLoaiDiaBan class</returns>
		public static LqPhanLoaiDiaBan CreateInstant()
		{
			return new LqPhanLoaiDiaBan();
		}
	}
}
