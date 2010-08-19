

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

namespace LayerHelper.CAQ.BUS
{
	public class KetQuaXuLyBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetQuaXuLyBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of KetQuaXuLyBus
		/// </summary>
		/// <returns>An instant of KetQuaXuLyBus class</returns>
		public static KetQuaXuLyBus CreateInstant()
		{
			return new KetQuaXuLyBus();
		}
	}
}
