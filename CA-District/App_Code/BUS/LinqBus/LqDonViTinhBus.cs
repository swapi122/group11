

/*
'===============================================================================
'  LinqHelper.BUS.LqDonViTinh
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
	public class LqDonViTinhBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDonViTinhBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDonViTinhBus
		/// </summary>
		/// <returns>An instant of LqDonViTinh class</returns>
		public static LqDonViTinhBus CreateInstant()
		{
			return new LqDonViTinhBus();
		}
	}
}
