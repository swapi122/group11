

/*
'===============================================================================
'  LayerHelper.CAQ.BL.NguoiDungVaNhomManager
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
	public class NguoiDungVaNhomBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NguoiDungVaNhomBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NguoiDungVaNhomBus
		/// </summary>
		/// <returns>An instant of NguoiDungVaNhomBus class</returns>
		public static NguoiDungVaNhomBus CreateInstant()
		{
			return new NguoiDungVaNhomBus();
		}
	}
}
