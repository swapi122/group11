

/*
'===============================================================================
'  LayerHelper.CAQ.BL.DoiTuongToChucManager
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
	public class DoiTuongToChucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DoiTuongToChucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DoiTuongToChucBus
		/// </summary>
		/// <returns>An instant of DoiTuongToChucBus class</returns>
		public static DoiTuongToChucBus CreateInstant()
		{
			return new DoiTuongToChucBus();
		}
	}
}
