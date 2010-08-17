
/*
'===============================================================================
'  LayerHelper.CAQ.BL.CscbManager
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
	public class CscbManager : CscbManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CscbManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of CscbManager
		/// </summary>
		/// <returns>An instant of CscbManager class</returns>
		public static CscbManager CreateInstant()
		{
			return new CscbManager();
		}
	}
}
