
/*
'===============================================================================
'  LayerHelper.CAQ.BL.XaManager
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
	public class XaManager : XaManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XaManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of XaManager
		/// </summary>
		/// <returns>An instant of XaManager class</returns>
		public static XaManager CreateInstant()
		{
			return new XaManager();
		}
	}
}
