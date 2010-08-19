

/*
'===============================================================================
'  LinqHelper.BUS.LqTinhChatVuViec
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
	public class LqTinhChatVuViecBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhChatVuViecBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqTinhChatVuViecBus
		/// </summary>
		/// <returns>An instant of LqTinhChatVuViec class</returns>
		public static LqTinhChatVuViecBus CreateInstant()
		{
			return new LqTinhChatVuViecBus();
		}
	}
}
