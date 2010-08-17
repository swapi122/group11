
/*
'===============================================================================
'  LayerHelper.CAQ.BL.GioiTinhManager
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
	public class GioiTinhManager : GioiTinhManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public GioiTinhManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of GioiTinhManager
		/// </summary>
		/// <returns>An instant of GioiTinhManager class</returns>
		public static GioiTinhManager CreateInstant()
		{
			return new GioiTinhManager();
		}
	}
}
