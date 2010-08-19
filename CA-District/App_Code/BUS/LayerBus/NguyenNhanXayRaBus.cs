

/*
'===============================================================================
'  LayerHelper.CAQ.BL.NguyenNhanXayRaManager
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
	public class NguyenNhanXayRaBus
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NguyenNhanXayRaBus()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NguyenNhanXayRaBus
		/// </summary>
		/// <returns>An instant of NguyenNhanXayRaBus class</returns>
		public static NguyenNhanXayRaBus CreateInstant()
		{
			return new NguyenNhanXayRaBus();
		}
	}
}
