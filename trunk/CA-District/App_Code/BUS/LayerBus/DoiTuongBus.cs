

/*
'===============================================================================
'  LayerHelper.CAQ.BL.DoiTuongManager
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
	public class DoiTuongBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DoiTuongBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DoiTuongBus
		/// </summary>
		/// <returns>An instant of DoiTuongBus class</returns>
		public static DoiTuongBus CreateInstant()
		{
			return new DoiTuongBus();
		}
	}
}
