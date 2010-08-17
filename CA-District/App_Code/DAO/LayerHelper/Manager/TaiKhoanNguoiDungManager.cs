
/*
'===============================================================================
'  LayerHelper.CAQ.BL.TaiKhoanNguoiDungManager
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
	public class TaiKhoanNguoiDungManager : TaiKhoanNguoiDungManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TaiKhoanNguoiDungManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TaiKhoanNguoiDungManager
		/// </summary>
		/// <returns>An instant of TaiKhoanNguoiDungManager class</returns>
		public static TaiKhoanNguoiDungManager CreateInstant()
		{
			return new TaiKhoanNguoiDungManager();
		}
	}
}
