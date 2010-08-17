
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

namespace LayerHelper.CAQ.BLL
{
	public class TinhTrangChinhTriManager : TinhTrangChinhTriManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhTrangChinhTriManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TinhTrangChinhTriManager
		/// </summary>
		/// <returns>An instant of TinhTrangChinhTriManager class</returns>
		public static TinhTrangChinhTriManager CreateInstant()
		{
			return new TinhTrangChinhTriManager();
		}
	}
}
