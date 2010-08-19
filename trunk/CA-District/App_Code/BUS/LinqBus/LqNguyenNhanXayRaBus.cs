

/*
'===============================================================================
'  LinqHelper.BUS.LqNguyenNhanXayRa
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
	public class LqNguyenNhanXayRaBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNguyenNhanXayRaBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNguyenNhanXayRaBus
		/// </summary>
		/// <returns>An instant of LqNguyenNhanXayRa class</returns>
		public static LqNguyenNhanXayRaBus CreateInstant()
		{
			return new LqNguyenNhanXayRaBus();
		}
	}
}
