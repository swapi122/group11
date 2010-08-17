
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

namespace LayerHelper.CAQ.BLL
{
	public class DonViCongAnManager : DonViCongAnManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DonViCongAnManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DonViCongAnManager
		/// </summary>
		/// <returns>An instant of DonViCongAnManager class</returns>
		public static DonViCongAnManager CreateInstant()
		{
			return new DonViCongAnManager();
		}
	}
}
