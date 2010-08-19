

/*
'===============================================================================
'  LinqHelper.BUS.LqTinhChatLienQuan
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
	public class LqTinhChatLienQuanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhChatLienQuanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTinhChatLienQuanBus
		/// </summary>
		/// <returns>An instant of LqTinhChatLienQuan class</returns>
		public static LqTinhChatLienQuanBus CreateInstant()
		{
			return new LqTinhChatLienQuanBus();
		}
	}
}
