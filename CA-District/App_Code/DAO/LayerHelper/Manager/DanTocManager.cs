
/*
'===============================================================================
'  LayerHelper.CAQ.BL.DanTocManager
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
	public class DanTocManager : DanTocManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DanTocManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DanTocManager
		/// </summary>
		/// <returns>An instant of DanTocManager class</returns>
		public static DanTocManager CreateInstant()
		{
			return new DanTocManager();
		}
	}
}
