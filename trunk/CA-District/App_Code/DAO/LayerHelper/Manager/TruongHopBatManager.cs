
/*
'===============================================================================
'  LayerHelper.CAQ.BL.TruongHopBatManager
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
	public class TruongHopBatManager : TruongHopBatManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TruongHopBatManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TruongHopBatManager
		/// </summary>
		/// <returns>An instant of TruongHopBatManager class</returns>
		public static TruongHopBatManager CreateInstant()
		{
			return new TruongHopBatManager();
		}
	}
}
