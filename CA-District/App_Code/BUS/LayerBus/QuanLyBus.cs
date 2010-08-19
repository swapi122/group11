

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

namespace LayerHelper.CAQ.BUS
{
	public class QuanLyBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public QuanLyBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of QuanLyBus
		/// </summary>
		/// <returns>An instant of QuanLyBus class</returns>
		public static QuanLyBus CreateInstant()
		{
			return new QuanLyBus();
		}
	}
}
