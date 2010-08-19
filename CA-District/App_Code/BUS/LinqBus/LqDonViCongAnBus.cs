

/*
'===============================================================================
'  LinqHelper.BUS.LqDonViCongAn
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
	public class LqDonViCongAnBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDonViCongAnBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDonViCongAnBus
		/// </summary>
		/// <returns>An instant of LqDonViCongAn class</returns>
		public static LqDonViCongAnBus CreateInstant()
		{
			return new LqDonViCongAnBus();
		}
	}
}
