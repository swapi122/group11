

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

namespace LayerHelper.CAQ.BUS
{
	public class HinhThucXuLyBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HinhThucXuLyBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of HinhThucXuLyBus
		/// </summary>
		/// <returns>An instant of HinhThucXuLyBus class</returns>
		public static HinhThucXuLyBus CreateInstant()
		{
			return new HinhThucXuLyBus();
		}
	}
}
