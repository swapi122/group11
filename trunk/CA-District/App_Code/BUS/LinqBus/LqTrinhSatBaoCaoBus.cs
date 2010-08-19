

/*
'===============================================================================
'  LinqHelper.BUS.LqTrinhSatBaoCao
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
	public class LqTrinhSatBaoCaoBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTrinhSatBaoCaoBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTrinhSatBaoCaoBus
		/// </summary>
		/// <returns>An instant of LqTrinhSatBaoCao class</returns>
		public static LqTrinhSatBaoCaoBus CreateInstant()
		{
			return new LqTrinhSatBaoCaoBus();
		}
	}
}
