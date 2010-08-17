
/*
'===============================================================================
'  LayerHelper.CAQ.BL.KhamPhaManager
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
	public class KhamPhaManager : KhamPhaManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KhamPhaManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of KhamPhaManager
		/// </summary>
		/// <returns>An instant of KhamPhaManager class</returns>
		public static KhamPhaManager CreateInstant()
		{
			return new KhamPhaManager();
		}
	}
}
