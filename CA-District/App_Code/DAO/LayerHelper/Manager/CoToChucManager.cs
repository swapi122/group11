
/*
'===============================================================================
'  LayerHelper.CAQ.BL.CoToChucManager
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
	public class CoToChucManager : CoToChucManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CoToChucManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of CoToChucManager
		/// </summary>
		/// <returns>An instant of CoToChucManager class</returns>
		public static CoToChucManager CreateInstant()
		{
			return new CoToChucManager();
		}
	}
}
