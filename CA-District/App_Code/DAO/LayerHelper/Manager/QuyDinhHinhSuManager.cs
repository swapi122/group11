
/*
'===============================================================================
'  LayerHelper.CAQ.BL.QuyDinhHinhSuManager
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
	public class QuyDinhHinhSuManager : QuyDinhHinhSuManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public QuyDinhHinhSuManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of QuyDinhHinhSuManager
		/// </summary>
		/// <returns>An instant of QuyDinhHinhSuManager class</returns>
		public static QuyDinhHinhSuManager CreateInstant()
		{
			return new QuyDinhHinhSuManager();
		}
	}
}
