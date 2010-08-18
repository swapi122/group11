
/*
'===============================================================================
'  LinqHelper.DAO.LqTrinhSatBaoCao
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
	public class LqTrinhSatBaoCao : LqTrinhSatBaoCaoBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTrinhSatBaoCao()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTrinhSatBaoCao
		/// </summary>
		/// <returns>An instant of LqTrinhSatBaoCao class</returns>
		public static LqTrinhSatBaoCao CreateInstant()
		{
			return new LqTrinhSatBaoCao();
		}
	}
}
