

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

namespace LayerHelper.CAQ.BUS
{
	public class TinhChatLienQuanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhChatLienQuanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TinhChatLienQuanBus
		/// </summary>
		/// <returns>An instant of TinhChatLienQuanBus class</returns>
		public static TinhChatLienQuanBus CreateInstant()
		{
			return new TinhChatLienQuanBus();
		}
	}
}
