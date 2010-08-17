
/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecTangVatManager
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
	public class VuViecTangVatManager : VuViecTangVatManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecTangVatManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VuViecTangVatManager
		/// </summary>
		/// <returns>An instant of VuViecTangVatManager class</returns>
		public static VuViecTangVatManager CreateInstant()
		{
			return new VuViecTangVatManager();
		}
	}
}
