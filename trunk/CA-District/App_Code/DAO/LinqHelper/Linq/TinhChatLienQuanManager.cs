
/*
'===============================================================================
'  LinqHelper.DAO.LqTinhChatLienQuan
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
	public class LqTinhChatLienQuan : LqTinhChatLienQuanBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhChatLienQuan()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTinhChatLienQuan
		/// </summary>
		/// <returns>An instant of LqTinhChatLienQuan class</returns>
		public static LqTinhChatLienQuan CreateInstant()
		{
			return new LqTinhChatLienQuan();
		}
	}
}
