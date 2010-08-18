
/*
'===============================================================================
'  LinqHelper.DAO.LqTangVat
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
	public class LqTangVat : LqTangVatBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTangVat()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTangVat
		/// </summary>
		/// <returns>An instant of LqTangVat class</returns>
		public static LqTangVat CreateInstant()
		{
			return new LqTangVat();
		}
	}
}
