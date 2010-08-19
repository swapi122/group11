

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

namespace LayerHelper.CAQ.BUS
{
	public class DieuTraDiaBanBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DieuTraDiaBanBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DieuTraDiaBanBus
		/// </summary>
		/// <returns>An instant of DieuTraDiaBanBus class</returns>
		public static DieuTraDiaBanBus CreateInstant()
		{
			return new DieuTraDiaBanBus();
		}
	}
}
