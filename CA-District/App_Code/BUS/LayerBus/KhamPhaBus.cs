

/*
'===============================================================================
'  LayerHelper.CAQ.BL.KhamPhaManager
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
	public class KhamPhaBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KhamPhaBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of KhamPhaBus
		/// </summary>
		/// <returns>An instant of KhamPhaBus class</returns>
		public static KhamPhaBus CreateInstant()
		{
			return new KhamPhaBus();
		}
	}
}
