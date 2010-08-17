
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

namespace LayerHelper.CAQ.BLL
{
	public class DieuTraToChucManager : DieuTraToChucManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DieuTraToChucManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DieuTraToChucManager
		/// </summary>
		/// <returns>An instant of DieuTraToChucManager class</returns>
		public static DieuTraToChucManager CreateInstant()
		{
			return new DieuTraToChucManager();
		}
	}
}
