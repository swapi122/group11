

/*
'===============================================================================
'  LayerHelper.CAQ.BL.TinhTrangChinhTriManager
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
	public class TinhTrangChinhTriBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhTrangChinhTriBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TinhTrangChinhTriBus
		/// </summary>
		/// <returns>An instant of TinhTrangChinhTriBus class</returns>
		public static TinhTrangChinhTriBus CreateInstant()
		{
			return new TinhTrangChinhTriBus();
		}
	}
}
