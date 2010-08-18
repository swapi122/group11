
/*
'===============================================================================
'  LinqHelper.DAO.LqDonViTinh
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
	public class LqDonViTinh : LqDonViTinhBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDonViTinh()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqDonViTinh
		/// </summary>
		/// <returns>An instant of LqDonViTinh class</returns>
		public static LqDonViTinh CreateInstant()
		{
			return new LqDonViTinh();
		}
	}
}
