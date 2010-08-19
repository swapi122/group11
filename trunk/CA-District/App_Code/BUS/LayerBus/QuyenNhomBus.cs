

/*
'===============================================================================
'  LayerHelper.CAQ.BL.QuyenNhomManager
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
	public class QuyenNhomBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public QuyenNhomBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of QuyenNhomBus
		/// </summary>
		/// <returns>An instant of QuyenNhomBus class</returns>
		public static QuyenNhomBus CreateInstant()
		{
			return new QuyenNhomBus();
		}
	}
}
