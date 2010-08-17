
/*
'===============================================================================
'  LayerHelper.CAQ.BL.NuocManager
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
	public class NuocManager : NuocManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NuocManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NuocManager
		/// </summary>
		/// <returns>An instant of NuocManager class</returns>
		public static NuocManager CreateInstant()
		{
			return new NuocManager();
		}
	}
}
