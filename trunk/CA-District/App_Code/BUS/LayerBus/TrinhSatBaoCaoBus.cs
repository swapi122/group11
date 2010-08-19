

/*
'===============================================================================
'  LayerHelper.CAQ.BL.TrinhSatBaoCaoManager
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
	public class TrinhSatBaoCaoBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TrinhSatBaoCaoBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TrinhSatBaoCaoBus
		/// </summary>
		/// <returns>An instant of TrinhSatBaoCaoBus class</returns>
		public static TrinhSatBaoCaoBus CreateInstant()
		{
			return new TrinhSatBaoCaoBus();
		}
	}
}
