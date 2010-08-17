
/*
'===============================================================================
'  LayerHelper.CAQ.BL.KetQuaXuLyManager
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
	public class KetQuaXuLyManager : KetQuaXuLyManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetQuaXuLyManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of KetQuaXuLyManager
		/// </summary>
		/// <returns>An instant of KetQuaXuLyManager class</returns>
		public static KetQuaXuLyManager CreateInstant()
		{
			return new KetQuaXuLyManager();
		}
	}
}
