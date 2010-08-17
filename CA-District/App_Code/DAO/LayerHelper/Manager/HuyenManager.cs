
/*
'===============================================================================
'  LayerHelper.CAQ.BL.HuyenManager
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
	public class HuyenManager : HuyenManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HuyenManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of HuyenManager
		/// </summary>
		/// <returns>An instant of HuyenManager class</returns>
		public static HuyenManager CreateInstant()
		{
			return new HuyenManager();
		}
	}
}
