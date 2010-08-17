
/*
'===============================================================================
'  LayerHelper.CAQ.BL.TangVatManager
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
	public class TangVatManager : TangVatManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TangVatManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TangVatManager
		/// </summary>
		/// <returns>An instant of TangVatManager class</returns>
		public static TangVatManager CreateInstant()
		{
			return new TangVatManager();
		}
	}
}
