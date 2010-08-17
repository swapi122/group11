
/*
'===============================================================================
'  LayerHelper.CAQ.BL.NguyenNhanXayRaManager
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
	public class NguyenNhanXayRaManager : NguyenNhanXayRaManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NguyenNhanXayRaManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NguyenNhanXayRaManager
		/// </summary>
		/// <returns>An instant of NguyenNhanXayRaManager class</returns>
		public static NguyenNhanXayRaManager CreateInstant()
		{
			return new NguyenNhanXayRaManager();
		}
	}
}
