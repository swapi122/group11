
/*
'===============================================================================
'  LayerHelper.CAQ.BL.PhuongThucThuDoanManager
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
	public class PhuongThucThuDoanManager : PhuongThucThuDoanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhuongThucThuDoanManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PhuongThucThuDoanManager
		/// </summary>
		/// <returns>An instant of PhuongThucThuDoanManager class</returns>
		public static PhuongThucThuDoanManager CreateInstant()
		{
			return new PhuongThucThuDoanManager();
		}
	}
}
