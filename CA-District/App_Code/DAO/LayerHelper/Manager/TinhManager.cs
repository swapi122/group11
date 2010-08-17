
/*
'===============================================================================
'  LayerHelper.CAQ.BL.TinhManager
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
	public class TinhManager : TinhManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TinhManager
		/// </summary>
		/// <returns>An instant of TinhManager class</returns>
		public static TinhManager CreateInstant()
		{
			return new TinhManager();
		}
	}
}
