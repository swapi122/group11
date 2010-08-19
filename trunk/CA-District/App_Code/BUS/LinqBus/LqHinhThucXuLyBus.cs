

/*
'===============================================================================
'  LinqHelper.BUS.LqHinhThucXuLy
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
	public class LqHinhThucXuLyBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHinhThucXuLyBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqHinhThucXuLyBus
		/// </summary>
		/// <returns>An instant of LqHinhThucXuLy class</returns>
		public static LqHinhThucXuLyBus CreateInstant()
		{
			return new LqHinhThucXuLyBus();
		}
	}
}
