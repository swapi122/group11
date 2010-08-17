
/*
'===============================================================================
'  LayerHelper.CAQ.BL.VanDeKhacManager
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
	public class VanDeKhacManager : VanDeKhacManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VanDeKhacManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VanDeKhacManager
		/// </summary>
		/// <returns>An instant of VanDeKhacManager class</returns>
		public static VanDeKhacManager CreateInstant()
		{
			return new VanDeKhacManager();
		}
	}
}
