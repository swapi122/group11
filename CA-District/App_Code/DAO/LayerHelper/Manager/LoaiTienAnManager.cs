
/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiTienAnManager
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
	public class LoaiTienAnManager : LoaiTienAnManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiTienAnManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LoaiTienAnManager
		/// </summary>
		/// <returns>An instant of LoaiTienAnManager class</returns>
		public static LoaiTienAnManager CreateInstant()
		{
			return new LoaiTienAnManager();
		}
	}
}
