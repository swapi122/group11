
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

namespace LayerHelper.CAQ.BLL
{
	public class QuyenNhomManager : QuyenNhomManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public QuyenNhomManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of QuyenNhomManager
		/// </summary>
		/// <returns>An instant of QuyenNhomManager class</returns>
		public static QuyenNhomManager CreateInstant()
		{
			return new QuyenNhomManager();
		}
	}
}
