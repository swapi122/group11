

/*
'===============================================================================
'  LayerHelper.CAQ.BL.TinhTrangTheTrangManager
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
	public class TinhTrangTheTrangBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhTrangTheTrangBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TinhTrangTheTrangBus
		/// </summary>
		/// <returns>An instant of TinhTrangTheTrangBus class</returns>
		public static TinhTrangTheTrangBus CreateInstant()
		{
			return new TinhTrangTheTrangBus();
		}
	}
}
