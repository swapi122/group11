
/*
'===============================================================================
'  LinqHelper.DAO.LqTinhChatVuViec
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
	public class LqTinhChatVuViec : LqTinhChatVuViecBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhChatVuViec()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTinhChatVuViec
		/// </summary>
		/// <returns>An instant of LqTinhChatVuViec class</returns>
		public static LqTinhChatVuViec CreateInstant()
		{
			return new LqTinhChatVuViec();
		}
	}
}
