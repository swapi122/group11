
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

namespace LayerHelper.CAQ.BLL
{
	public class DonViTinhManager : DonViTinhManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DonViTinhManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DonViTinhManager
		/// </summary>
		/// <returns>An instant of DonViTinhManager class</returns>
		public static DonViTinhManager CreateInstant()
		{
			return new DonViTinhManager();
		}
	}
}
