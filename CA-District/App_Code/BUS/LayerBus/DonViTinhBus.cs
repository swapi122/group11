

/*
'===============================================================================
'  LayerHelper.CAQ.BL.DonViTinhManager
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
	public class DonViTinhBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DonViTinhBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DonViTinhBus
		/// </summary>
		/// <returns>An instant of DonViTinhBus class</returns>
		public static DonViTinhBus CreateInstant()
		{
			return new DonViTinhBus();
		}
	}
}
