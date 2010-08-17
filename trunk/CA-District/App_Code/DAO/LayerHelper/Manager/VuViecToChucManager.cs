
/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecToChucManager
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
	public class VuViecToChucManager : VuViecToChucManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecToChucManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VuViecToChucManager
		/// </summary>
		/// <returns>An instant of VuViecToChucManager class</returns>
		public static VuViecToChucManager CreateInstant()
		{
			return new VuViecToChucManager();
		}
	}
}
