
/*
'===============================================================================
'  LayerHelper.CAQ.BL.TapTinDinhKemManager
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
	public class TapTinDinhKemManager : TapTinDinhKemManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TapTinDinhKemManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TapTinDinhKemManager
		/// </summary>
		/// <returns>An instant of TapTinDinhKemManager class</returns>
		public static TapTinDinhKemManager CreateInstant()
		{
			return new TapTinDinhKemManager();
		}
	}
}
