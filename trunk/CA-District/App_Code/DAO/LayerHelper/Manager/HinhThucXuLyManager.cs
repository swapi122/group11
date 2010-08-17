
/*
'===============================================================================
'  LayerHelper.CAQ.BL.HinhThucXuLyManager
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
	public class HinhThucXuLyManager : HinhThucXuLyManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HinhThucXuLyManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of HinhThucXuLyManager
		/// </summary>
		/// <returns>An instant of HinhThucXuLyManager class</returns>
		public static HinhThucXuLyManager CreateInstant()
		{
			return new HinhThucXuLyManager();
		}
	}
}
