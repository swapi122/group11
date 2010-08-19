

/*
'===============================================================================
'  LayerHelper.CAQ.BL.DonViCongAnManager
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
	public class DonViCongAnBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DonViCongAnBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DonViCongAnBus
		/// </summary>
		/// <returns>An instant of DonViCongAnBus class</returns>
		public static DonViCongAnBus CreateInstant()
		{
			return new DonViCongAnBus();
		}
	}
}
