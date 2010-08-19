
/*
'===============================================================================
'  LinqHelper.DAO.LqDiaBan
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
	public class LqDiaBan : LqDiaBanBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDiaBan()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDiaBan
		/// </summary>
		/// <returns>An instant of LqDiaBan class</returns>
		public static LqDiaBan CreateInstant()
		{
			return new LqDiaBan();
		}
	}
}
