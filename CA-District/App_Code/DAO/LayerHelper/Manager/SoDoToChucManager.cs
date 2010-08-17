
/*
'===============================================================================
'  LayerHelper.CAQ.BL.SoDoToChucManager
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
	public class SoDoToChucManager : SoDoToChucManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SoDoToChucManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of SoDoToChucManager
		/// </summary>
		/// <returns>An instant of SoDoToChucManager class</returns>
		public static SoDoToChucManager CreateInstant()
		{
			return new SoDoToChucManager();
		}
	}
}
