

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

namespace LayerHelper.CAQ.BUS
{
	public class PhanLoaiChuyenDeBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhanLoaiChuyenDeBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PhanLoaiChuyenDeBus
		/// </summary>
		/// <returns>An instant of PhanLoaiChuyenDeBus class</returns>
		public static PhanLoaiChuyenDeBus CreateInstant()
		{
			return new PhanLoaiChuyenDeBus();
		}
	}
}
