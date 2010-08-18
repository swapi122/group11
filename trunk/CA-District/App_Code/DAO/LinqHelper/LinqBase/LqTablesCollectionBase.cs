




/*
'===============================================================================
'  LinqHelper.DAO.TablesCollectionBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqTablesCollectionBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTablesCollectionBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTablesCollectionEntity obj)
		{
			provider.GetTable<LqTablesCollectionEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTablesCollectionEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTablesCollectionEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTablesCollectionEntity tmp = q.First<LqTablesCollectionEntity>();
			
			tmp.TableName = _obj.TableName;
			tmp.TableTitle = _obj.TableTitle;
			tmp.Fk = _obj.Fk;
			tmp.IsMultiLevel = _obj.IsMultiLevel;
		}
		
		public void Delete(LqTablesCollectionEntity obj)
		{
			provider.GetTable<LqTablesCollectionEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTablesCollectionEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTablesCollectionEntity ob = (LqTablesCollectionEntity)q.First<LqTablesCollectionEntity>();
            provider.GetTable<LqTablesCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTableName(string TableName)
		{
			var q = from obj in provider.GetTable<LqTablesCollectionEntity>()
                    where obj.TableName == TableName
                    select obj;
					
            LqTablesCollectionEntity ob = (LqTablesCollectionEntity)q.First<LqTablesCollectionEntity>();
            provider.GetTable<LqTablesCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTableTitle(string TableTitle)
		{
			var q = from obj in provider.GetTable<LqTablesCollectionEntity>()
                    where obj.TableTitle == TableTitle
                    select obj;
					
            LqTablesCollectionEntity ob = (LqTablesCollectionEntity)q.First<LqTablesCollectionEntity>();
            provider.GetTable<LqTablesCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByFk(bool Fk)
		{
			var q = from obj in provider.GetTable<LqTablesCollectionEntity>()
                    where obj.Fk == Fk
                    select obj;
					
            LqTablesCollectionEntity ob = (LqTablesCollectionEntity)q.First<LqTablesCollectionEntity>();
            provider.GetTable<LqTablesCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIsMultiLevel(bool IsMultiLevel)
		{
			var q = from obj in provider.GetTable<LqTablesCollectionEntity>()
                    where obj.IsMultiLevel == IsMultiLevel
                    select obj;
					
            LqTablesCollectionEntity ob = (LqTablesCollectionEntity)q.First<LqTablesCollectionEntity>();
            provider.GetTable<LqTablesCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTablesCollectionEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTablesCollectionEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTablesCollectionEntity>();
		}

		public List<LqTablesCollectionEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTablesCollectionEntity>()
                        select obj;
            return query.ToList<LqTablesCollectionEntity>();
		}
		
		
		public List<LqTablesCollectionEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTablesCollectionEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTablesCollectionEntity>();
		}
		
		
		public List<LqTablesCollectionEntity> SelectByTableName(string TableName)
		{
			var query = from obj in provider.GetTable<LqTablesCollectionEntity>()
                        where obj.TableName == TableName
                        select obj;
            return query.ToList<LqTablesCollectionEntity>();
		}
		
		
		public List<LqTablesCollectionEntity> SelectByTableTitle(string TableTitle)
		{
			var query = from obj in provider.GetTable<LqTablesCollectionEntity>()
                        where obj.TableTitle == TableTitle
                        select obj;
            return query.ToList<LqTablesCollectionEntity>();
		}
		
		
		public List<LqTablesCollectionEntity> SelectByFk(bool Fk)
		{
			var query = from obj in provider.GetTable<LqTablesCollectionEntity>()
                        where obj.Fk == Fk
                        select obj;
            return query.ToList<LqTablesCollectionEntity>();
		}
		
		
		public List<LqTablesCollectionEntity> SelectByIsMultiLevel(bool IsMultiLevel)
		{
			var query = from obj in provider.GetTable<LqTablesCollectionEntity>()
                        where obj.IsMultiLevel == IsMultiLevel
                        select obj;
            return query.ToList<LqTablesCollectionEntity>();
		}
		
		
		

	}
}
