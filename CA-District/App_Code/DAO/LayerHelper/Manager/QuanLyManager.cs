
/*
'===============================================================================
'  LayerHelper.CAQ.BL.QuanLyManager
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
	public class QuanLyManager : QuanLyManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public QuanLyManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of QuanLyManager
		/// </summary>
		/// <returns>An instant of QuanLyManager class</returns>
		public static QuanLyManager CreateInstant()
		{
			return new QuanLyManager();
		}
	}
}
