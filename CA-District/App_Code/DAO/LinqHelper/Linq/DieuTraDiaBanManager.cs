
/*
'===============================================================================
'  LinqHelper.DAO.LqDieuTraDiaBan
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
	public class LqDieuTraDiaBan : LqDieuTraDiaBanBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDieuTraDiaBan()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDieuTraDiaBan
		/// </summary>
		/// <returns>An instant of LqDieuTraDiaBan class</returns>
		public static LqDieuTraDiaBan CreateInstant()
		{
			return new LqDieuTraDiaBan();
		}
	}
}
