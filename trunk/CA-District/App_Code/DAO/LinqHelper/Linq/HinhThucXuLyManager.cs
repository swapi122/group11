
/*
'===============================================================================
'  LinqHelper.DAO.LqHinhThucXuLy
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
	public class LqHinhThucXuLy : LqHinhThucXuLyBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHinhThucXuLy()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqHinhThucXuLy
		/// </summary>
		/// <returns>An instant of LqHinhThucXuLy class</returns>
		public static LqHinhThucXuLy CreateInstant()
		{
			return new LqHinhThucXuLy();
		}
	}
}
