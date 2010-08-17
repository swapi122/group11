
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

namespace LayerHelper.CAQ.BLL
{
	public class NguoiDungVaNhomManager : NguoiDungVaNhomManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NguoiDungVaNhomManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NguoiDungVaNhomManager
		/// </summary>
		/// <returns>An instant of NguoiDungVaNhomManager class</returns>
		public static NguoiDungVaNhomManager CreateInstant()
		{
			return new NguoiDungVaNhomManager();
		}
	}
}
