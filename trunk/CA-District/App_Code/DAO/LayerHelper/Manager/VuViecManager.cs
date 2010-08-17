
/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecManager
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
	public class VuViecManager : VuViecManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VuViecManager
		/// </summary>
		/// <returns>An instant of VuViecManager class</returns>
		public static VuViecManager CreateInstant()
		{
			return new VuViecManager();
		}
	}
}
