
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

namespace LayerHelper.CAQ.BLL
{
	public class TinhTrangTheTrangManager : TinhTrangTheTrangManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhTrangTheTrangManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TinhTrangTheTrangManager
		/// </summary>
		/// <returns>An instant of TinhTrangTheTrangManager class</returns>
		public static TinhTrangTheTrangManager CreateInstant()
		{
			return new TinhTrangTheTrangManager();
		}
	}
}
