
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

namespace LayerHelper.CAQ.BLL
{
	public class NhomNguoiDungManager : NhomNguoiDungManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NhomNguoiDungManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NhomNguoiDungManager
		/// </summary>
		/// <returns>An instant of NhomNguoiDungManager class</returns>
		public static NhomNguoiDungManager CreateInstant()
		{
			return new NhomNguoiDungManager();
		}
	}
}
