
/*
'===============================================================================
'  LinqHelper.DAO.LqVuViecTangVat
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
	public class LqVuViecTangVat : LqVuViecTangVatBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecTangVat()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqVuViecTangVat
		/// </summary>
		/// <returns>An instant of LqVuViecTangVat class</returns>
		public static LqVuViecTangVat CreateInstant()
		{
			return new LqVuViecTangVat();
		}
	}
}
