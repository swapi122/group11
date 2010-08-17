
/*
'===============================================================================
'  LayerHelper.CAQ.BL.DieuTraDiaBanManager
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
	public class DieuTraDiaBanManager : DieuTraDiaBanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DieuTraDiaBanManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DieuTraDiaBanManager
		/// </summary>
		/// <returns>An instant of DieuTraDiaBanManager class</returns>
		public static DieuTraDiaBanManager CreateInstant()
		{
			return new DieuTraDiaBanManager();
		}
	}
}
