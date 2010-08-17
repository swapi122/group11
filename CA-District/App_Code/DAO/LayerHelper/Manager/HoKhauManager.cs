
/*
'===============================================================================
'  LayerHelper.CAQ.BL.HoKhauManager
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{
	public class HoKhauManager : HoKhauManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HoKhauManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of HoKhauManager
		/// </summary>
		/// <returns>An instant of HoKhauManager class</returns>
		public static HoKhauManager CreateInstant()
		{
			return new HoKhauManager();
		}
	}
}
