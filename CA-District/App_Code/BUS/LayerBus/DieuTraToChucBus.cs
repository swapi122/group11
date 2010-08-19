

/*
'===============================================================================
'  LayerHelper.CAQ.BL.DieuTraToChucManager
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
	public class DieuTraToChucBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DieuTraToChucBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DieuTraToChucBus
		/// </summary>
		/// <returns>An instant of DieuTraToChucBus class</returns>
		public static DieuTraToChucBus CreateInstant()
		{
			return new DieuTraToChucBus();
		}
	}
}
