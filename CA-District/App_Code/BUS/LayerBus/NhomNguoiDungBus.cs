

/*
'===============================================================================
'  LayerHelper.CAQ.BL.NhomNguoiDungManager
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
	public class NhomNguoiDungBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NhomNguoiDungBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NhomNguoiDungBus
		/// </summary>
		/// <returns>An instant of NhomNguoiDungBus class</returns>
		public static NhomNguoiDungBus CreateInstant()
		{
			return new NhomNguoiDungBus();
		}
	}
}
