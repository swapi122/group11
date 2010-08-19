

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

namespace LayerHelper.CAQ.BUS
{
	public class QuyDinhHinhSuBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public QuyDinhHinhSuBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of QuyDinhHinhSuBus
		/// </summary>
		/// <returns>An instant of QuyDinhHinhSuBus class</returns>
		public static QuyDinhHinhSuBus CreateInstant()
		{
			return new QuyDinhHinhSuBus();
		}
	}
}
