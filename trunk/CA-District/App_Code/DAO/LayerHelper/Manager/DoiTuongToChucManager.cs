
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

namespace LayerHelper.CAQ.BLL
{
	public class DoiTuongToChucManager : DoiTuongToChucManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DoiTuongToChucManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DoiTuongToChucManager
		/// </summary>
		/// <returns>An instant of DoiTuongToChucManager class</returns>
		public static DoiTuongToChucManager CreateInstant()
		{
			return new DoiTuongToChucManager();
		}
	}
}
