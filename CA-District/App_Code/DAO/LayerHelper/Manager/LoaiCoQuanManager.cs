
/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiCoQuanManager
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
	public class LoaiCoQuanManager : LoaiCoQuanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiCoQuanManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LoaiCoQuanManager
		/// </summary>
		/// <returns>An instant of LoaiCoQuanManager class</returns>
		public static LoaiCoQuanManager CreateInstant()
		{
			return new LoaiCoQuanManager();
		}
	}
}
