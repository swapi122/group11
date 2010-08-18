
/*
'===============================================================================
'  LinqHelper.DAO.LqLoaiDiaBan
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
	public class LqLoaiDiaBan : LqLoaiDiaBanBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiDiaBan()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqLoaiDiaBan
		/// </summary>
		/// <returns>An instant of LqLoaiDiaBan class</returns>
		public static LqLoaiDiaBan CreateInstant()
		{
			return new LqLoaiDiaBan();
		}
	}
}
