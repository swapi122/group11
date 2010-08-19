

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

namespace LayerHelper.CAQ.BUS
{
	public class VuViecTangVatBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecTangVatBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VuViecTangVatBus
		/// </summary>
		/// <returns>An instant of VuViecTangVatBus class</returns>
		public static VuViecTangVatBus CreateInstant()
		{
			return new VuViecTangVatBus();
		}
	}
}
