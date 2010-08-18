




/*
'===============================================================================
'  LinqHelper.DAO.ColumnsCollectionBase
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
	public class LqColumnsCollectionBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqColumnsCollectionBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqColumnsCollectionEntity obj)
		{
			provider.GetTable<LqColumnsCollectionEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqColumnsCollectionEntity _obj)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqColumnsCollectionEntity tmp = q.First<LqColumnsCollectionEntity>();
			
			tmp.TableName = _obj.TableName;
			tmp.ColumnName = _obj.ColumnName;
			tmp.Title = _obj.Title;
			tmp.SqlDataType = _obj.SqlDataType;
			tmp.KeyType = _obj.KeyType;
			tmp.OrderIndex = _obj.OrderIndex;
			tmp.IsShow = _obj.IsShow;
			tmp.IsNullable = _obj.IsNullable;
			tmp.Control = _obj.Control;
			tmp.MaxLength = _obj.MaxLength;
			tmp.Width = _obj.Width;
			tmp.ColumnId = _obj.ColumnId;
		}
		
		public void Delete(LqColumnsCollectionEntity obj)
		{
			provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTableName(string TableName)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.TableName == TableName
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByColumnName(string ColumnName)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.ColumnName == ColumnName
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTitle(string Title)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.Title == Title
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySqlDataType(string SqlDataType)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.SqlDataType == SqlDataType
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByKeyType(string KeyType)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.KeyType == KeyType
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByOrderIndex(int OrderIndex)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.OrderIndex == OrderIndex
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIsShow(bool IsShow)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.IsShow == IsShow
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIsNullable(bool IsNullable)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.IsNullable == IsNullable
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByControl(string Control)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.Control == Control
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaxLength(int MaxLength)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.MaxLength == MaxLength
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByWidth(string Width)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.Width == Width
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByColumnId(Guid ColumnId)
		{
			var q = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                    where obj.ColumnId.Value == ColumnId
                    select obj;
					
            LqColumnsCollectionEntity ob = (LqColumnsCollectionEntity)q.First<LqColumnsCollectionEntity>();
            provider.GetTable<LqColumnsCollectionEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqColumnsCollectionEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqColumnsCollectionEntity>();
		}

		public List<LqColumnsCollectionEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectByTableName(string TableName)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.TableName == TableName
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectByColumnName(string ColumnName)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.ColumnName == ColumnName
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectByTitle(string Title)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.Title == Title
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectBySqlDataType(string SqlDataType)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.SqlDataType == SqlDataType
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectByKeyType(string KeyType)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.KeyType == KeyType
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectByOrderIndex(int OrderIndex)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.OrderIndex == OrderIndex
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectByIsShow(bool IsShow)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.IsShow == IsShow
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectByIsNullable(bool IsNullable)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.IsNullable == IsNullable
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectByControl(string Control)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.Control == Control
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectByMaxLength(int MaxLength)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.MaxLength == MaxLength
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectByWidth(string Width)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.Width == Width
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		public List<LqColumnsCollectionEntity> SelectByColumnId(Guid ColumnId)
		{
			var query = from obj in provider.GetTable<LqColumnsCollectionEntity>()
                        where obj.ColumnId.Value == ColumnId
                        select obj;
            return query.ToList<LqColumnsCollectionEntity>();
		}
		
		
		

	}
}
