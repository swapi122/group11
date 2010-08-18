
/*
'===============================================================================
'  LinqHelper.DAO.LqTruongHopBat
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
	public class LqTruongHopBat : LqTruongHopBatBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTruongHopBat()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTruongHopBat
		/// </summary>
		/// <returns>An instant of LqTruongHopBat class</returns>
		public static LqTruongHopBat CreateInstant()
		{
			return new LqTruongHopBat();
		}
	}
}
