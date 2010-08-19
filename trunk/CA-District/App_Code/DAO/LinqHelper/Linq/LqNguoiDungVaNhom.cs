
/*
'===============================================================================
'  LinqHelper.DAO.LqNguoiDungVaNhom
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
	public class LqNguoiDungVaNhom : LqNguoiDungVaNhomBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNguoiDungVaNhom()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqNguoiDungVaNhom
		/// </summary>
		/// <returns>An instant of LqNguoiDungVaNhom class</returns>
		public static LqNguoiDungVaNhom CreateInstant()
		{
			return new LqNguoiDungVaNhom();
		}
	}
}
