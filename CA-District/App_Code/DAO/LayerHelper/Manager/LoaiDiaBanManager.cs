
/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiDiaBanManager
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
	public class LoaiDiaBanManager : LoaiDiaBanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiDiaBanManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LoaiDiaBanManager
		/// </summary>
		/// <returns>An instant of LoaiDiaBanManager class</returns>
		public static LoaiDiaBanManager CreateInstant()
		{
			return new LoaiDiaBanManager();
		}
	}
}
