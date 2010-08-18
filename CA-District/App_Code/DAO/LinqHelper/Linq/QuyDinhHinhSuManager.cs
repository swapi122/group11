
/*
'===============================================================================
'  LinqHelper.DAO.LqQuyDinhHinhSu
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
	public class LqQuyDinhHinhSu : LqQuyDinhHinhSuBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqQuyDinhHinhSu()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqQuyDinhHinhSu
		/// </summary>
		/// <returns>An instant of LqQuyDinhHinhSu class</returns>
		public static LqQuyDinhHinhSu CreateInstant()
		{
			return new LqQuyDinhHinhSu();
		}
	}
}
