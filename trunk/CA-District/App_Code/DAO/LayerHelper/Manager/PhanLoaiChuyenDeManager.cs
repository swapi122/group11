
/*
'===============================================================================
'  LayerHelper.CAQ.BL.PhanLoaiChuyenDeManager
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
	public class PhanLoaiChuyenDeManager : PhanLoaiChuyenDeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhanLoaiChuyenDeManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PhanLoaiChuyenDeManager
		/// </summary>
		/// <returns>An instant of PhanLoaiChuyenDeManager class</returns>
		public static PhanLoaiChuyenDeManager CreateInstant()
		{
			return new PhanLoaiChuyenDeManager();
		}
	}
}
