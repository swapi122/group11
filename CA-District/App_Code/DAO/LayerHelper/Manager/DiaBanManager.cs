
/*
'===============================================================================
'  LayerHelper.CAQ.BL.DiaBanManager
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
	public class DiaBanManager : DiaBanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DiaBanManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DiaBanManager
		/// </summary>
		/// <returns>An instant of DiaBanManager class</returns>
		public static DiaBanManager CreateInstant()
		{
			return new DiaBanManager();
		}
	}
}
