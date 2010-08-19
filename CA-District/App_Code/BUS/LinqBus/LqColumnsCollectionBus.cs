

/*
'===============================================================================
'  LinqHelper.BUS.LqColumnsCollection
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
	public class LqColumnsCollectionBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqColumnsCollectionBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqColumnsCollectionBus
		/// </summary>
		/// <returns>An instant of LqColumnsCollection class</returns>
		public static LqColumnsCollectionBus CreateInstant()
		{
			return new LqColumnsCollectionBus();
		}
	}
}
