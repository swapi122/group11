
/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiTienManager
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
	public class LoaiTienManager : LoaiTienManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiTienManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LoaiTienManager
		/// </summary>
		/// <returns>An instant of LoaiTienManager class</returns>
		public static LoaiTienManager CreateInstant()
		{
			return new LoaiTienManager();
		}
	}
}
