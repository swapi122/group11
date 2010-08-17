
/*
'===============================================================================
'  LayerHelper.CAQ.BL.TinhChatLienQuanManager
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
	public class TinhChatLienQuanManager : TinhChatLienQuanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhChatLienQuanManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TinhChatLienQuanManager
		/// </summary>
		/// <returns>An instant of TinhChatLienQuanManager class</returns>
		public static TinhChatLienQuanManager CreateInstant()
		{
			return new TinhChatLienQuanManager();
		}
	}
}
