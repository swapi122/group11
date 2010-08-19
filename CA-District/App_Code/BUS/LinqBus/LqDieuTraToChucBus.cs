

/*
'===============================================================================
'  LinqHelper.BUS.LqDieuTraToChuc
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
	public class LqDieuTraToChucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDieuTraToChucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDieuTraToChucBus
		/// </summary>
		/// <returns>An instant of LqDieuTraToChuc class</returns>
		public static LqDieuTraToChucBus CreateInstant()
		{
			return new LqDieuTraToChucBus();
		}
	}
}
