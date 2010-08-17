
/*
'===============================================================================
'  LayerHelper.CAQ.BL.KiemDienManager
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
	public class KiemDienManager : KiemDienManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KiemDienManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of KiemDienManager
		/// </summary>
		/// <returns>An instant of KiemDienManager class</returns>
		public static KiemDienManager CreateInstant()
		{
			return new KiemDienManager();
		}
	}
}
