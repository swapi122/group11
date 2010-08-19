

/*
'===============================================================================
'  LinqHelper.BUS.LqQuyDinhHinhSu
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
	public class LqQuyDinhHinhSuBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqQuyDinhHinhSuBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LqQuyDinhHinhSuBus
		/// </summary>
		/// <returns>An instant of LqQuyDinhHinhSu class</returns>
		public static LqQuyDinhHinhSuBus CreateInstant()
		{
			return new LqQuyDinhHinhSuBus();
		}
	}
}
