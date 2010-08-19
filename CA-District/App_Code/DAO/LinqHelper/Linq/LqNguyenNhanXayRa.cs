
/*
'===============================================================================
'  LinqHelper.DAO.LqNguyenNhanXayRa
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
	public class LqNguyenNhanXayRa : LqNguyenNhanXayRaBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNguyenNhanXayRa()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNguyenNhanXayRa
		/// </summary>
		/// <returns>An instant of LqNguyenNhanXayRa class</returns>
		public static LqNguyenNhanXayRa CreateInstant()
		{
			return new LqNguyenNhanXayRa();
		}
	}
}
